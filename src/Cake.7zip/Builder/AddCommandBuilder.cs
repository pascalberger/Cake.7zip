namespace Cake.SevenZip.Builder
{
    using Cake.Core.IO;
    using Cake.SevenZip.Commands;
    using Cake.SevenZip.Switches;

    /// <summary>
    /// Builder for <see cref="AddCommand"/>.
    /// </summary>
    /// <seealso cref="ISupportSwitchBuilder{ISupportSwitchVolume}" />
    public sealed class AddCommandBuilder :
        ISupportSwitchBuilder<ISupportSwitchVolume>
    {
        private AddCommand command;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddCommandBuilder"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        internal AddCommandBuilder(ref AddCommand command)
        {
            this.command = command;
        }

        /// <inheritdoc/>
        ISupportSwitchVolume ISupportSwitchBuilder<ISupportSwitchVolume>.Command => command;

        /// <summary>
        /// Sets the archive on the <see cref="AddCommand"/>.
        /// </summary>
        /// <param name="archive">The archive.</param>
        /// <returns>The builder, for fluent use.</returns>
        public AddCommandBuilder WithArchive(FilePath archive)
        {
            command.Archive = archive;
            return this;
        }

        /// <summary>
        /// Sets the dierectories on the <see cref="AddCommand"/>.
        /// </summary>
        /// <param name="directories">The directories.</param>
        /// <returns>The builder, for fluent use.</returns>
        public AddCommandBuilder WithDirectories(params DirectoryPath[] directories)
        {
            if (command.Directories == null)
            {
                command.Directories = new DirectoryPathCollection();
            }

            foreach (var d in directories)
            {
                command.Directories.Add(d);
            }

            return this;
        }

        /// <summary>
        /// Sets the files on the <see cref="AddCommand"/>.
        /// </summary>
        /// <param name="files">The files.</param>
        /// <returns>The builder, for fluent use.</returns>
        public AddCommandBuilder WithFiles(params FilePath[] files)
        {
            if (command.Files == null)
            {
                command.Files = new FilePathCollection();
            }

            foreach (var f in files)
            {
                command.Files.Add(f);
            }

            return this;
        }
    }
}
