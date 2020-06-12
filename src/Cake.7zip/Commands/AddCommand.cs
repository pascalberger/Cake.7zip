namespace Cake.SevenZip.Commands
{
    using System;
    using System.IO;
    using System.Linq;

    using Cake.Core;
    using Cake.Core.IO;
    using Cake.SevenZip.Switches;

    /* Switches that can be used with this command
    -i (Include)
    -m (Method)
    -p (Set Password)
    -r (Recurse)
    -sdel (Delete files after including to archive)
    -sfx (create SFX)
    -si (use StdIn)
    -sni (Store NT security information)
    -sns (Store NTFS alternate Streams)
    -so (use StdOut)
    -spf (Use fully qualified file paths)
    -ssw (Compress shared files)
    -stl (Set archive timestamp from the most recently modified file)
    -t (Type of archive)
    -u (Update)
    -v (Volumes)
    -w (Working Dir)
    -x (Exclude)
    */

    /// <summary>
    /// Represents an Add-Command.
    /// </summary>
    public sealed class AddCommand : BaseCommand,
        ISupportSwitchVolume
    {
        /// <summary>
        /// Gets or sets The list of Files to add to the package.
        /// </summary>
        public FilePathCollection Files { get; set; }

        /// <summary>
        /// Gets or sets the list of Directories to add to the package.
        /// Consider using the recurse-switch and/or filter-switch if you add Directories.
        /// </summary>
        public DirectoryPathCollection Directories { get; set; }

        /// <summary>
        /// Gets or sets the archive to add the files to.
        /// </summary>
        public FilePath Archive { get; set; }

        /// <summary>
        /// Gets or Sets Volume-switches.
        /// </summary>
        public SwitchVolumeCollection Volumes { get; set; }

        /// <summary>
        /// Gets or sets the method-switch.
        /// </summary>
        public SwitchCompressionMethod Method { get; set; }

        /// <inheritdoc/>
        internal override void BuildArguments(ref ProcessArgumentBuilder builder)
        {
            if (Archive == null)
            {
                throw new ArgumentException("output Archive is required for add.");
            }

            if ((Files == null || Files.Count == 0)
                && (Directories == null || Directories.Count == 0))
            {
                throw new ArgumentException("some input (Files or Directories) is required for add.");
            }

            builder.Append("-a");

            foreach (var sw in new BaseSwitch[]
            {
        Method,
        Volumes,
            })
            {
                if (sw == null)
                {
                    continue;
                }

                sw.BuildArguments(ref builder);
            }

            builder.AppendQuoted(Archive.FullPath);

            if (Files != null)
            {
                foreach (var f in Files)
                {
                    builder.AppendQuoted(f.FullPath);
                }
            }

            if (Directories != null)
            {
                foreach (var d in Directories)
                {
                    builder.AppendQuoted(d.FullPath);
                }
            }
        }
    }
}
