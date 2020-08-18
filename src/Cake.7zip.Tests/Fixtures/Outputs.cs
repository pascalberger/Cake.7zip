namespace Cake.SevenZip.Tests.Fixtures
{
    public static class Outputs
    {
        public static string[] Information
        {
            get
            {
                const string demoOutput = @"
7-Zip 19.00 (x64) : Copyright (c) 1999-2018 Igor Pavlov : 2019-02-21

Libs:
 0  C:\Program Files\7-Zip\7z.dll

Formats:
 0               APM      apm           E R
 0               Ar       ar a deb lib  ! < a r c h > 0A
 0               Arj      arj           ` EA
 0 CK            bzip2    bz2 bzip2 tbz2 (.tar) tbz (.tar) B Z h
 0               Compound msi msp doc xls ppt D0 CF 11 E0 A1 B1 1A E1
 0      M        Cpio     cpio          0 7 0 7 0  ||  C7 q  ||  q C7
 0               CramFS   cramfs        offset=16 C o m p r e s s e d 20 R O M F S
 0       G  B    Dmg      dmg           k o l y 00 00 00 04 00 00 02 00
 0           E   ELF      elf           ⌂ E L F
 0               Ext      ext ext2 ext3 ext4 img offset=1080 S EF
 0               FAT      fat img       offset=510 U AA
 0               FLV      flv           F L V 01
 0 CK            gzip     gz gzip tgz (.tar) tpz (.tar) apk (.tar) 1F 8B 08
 0               GPT      gpt mbr       offset=512 E F I 20 P A R T 00 00 01 00
 0      M        HFS      hfs hfsx      offset=1024 B D  ||  H + 00 04  ||  H X 00 05
 0        O      IHex     ihex
 0               Lzh      lzh lha       offset=2 - l h
 0  K     O      lzma     lzma
 0  K            lzma86   lzma86
 0      M    E   MachO    macho         CE FA ED FE  ||  CF FA ED FE  ||  FE ED FA CE  ||  FE ED FA CF
 0         P     MBR      mbr
 0               MsLZ     mslz          S Z D D 88 F0 ' 3 A
 0      M        Mub      mub           CA FE BA BE 00 00 00  ||  B9 FA F1 0E
 0               NTFS     ntfs img      offset=3 N T F S 20 20 20 20 00
 0           E   PE       exe dll sys   M Z
 0        O      COFF     obj
 0           E   TE       te            V Z
 0               Ppmd     pmd           8F AF AC 84
 0               QCOW     qcow qcow2 qcow2c Q F I FB 00 00 00
 0               Rpm      rpm           ED AB EE DB
 0               Split    001
 0      M        SquashFS squashfs      h s q s  ||  s q s h  ||  s h s q  ||  q s h s
 0 C    M        SWFc     swf (~.swf)   C W S  ||  Z W S
 0  K            SWF      swf           F W S
 0     FM        UEFIc    scap          BD 86 f ; v 0D 0 @ B7 0E B5 Q 9E / C5 A0  ||  8B A6 < J # w FB H 80 = W 8C C1 FE C4 M  ||  B9 82 91 S B5 AB 91 C B6 9A E3 A9 C F7 / CC
 0     FM        UEFIf    uefif         offset=16 D9 T 93 z h 04 J D 81 CE 0B F6 17 D8 90 DF  ||  x E5 8C 8C = 8A 1C O 99 5 89 a 85 C3 - D3
 0               VDI      vdi           offset=64 ⌂ 10 DA BE
 0       G       VHD      vhd           c o n e c t i x 00 00
 0               VMDK     vmdk          K D M V
 0               Xar      xar pkg xip   x a r ! 00 1C
 0 CK            xz       xz txz (.tar) FD 7 z X Z 00
 0               Z        z taz (.tar)  1F 9D
 0 C   F         7z       7z            7 z BC AF ' 1C
 0     F         Cab      cab           M S C F 00 00 00 00
 0               Chm      chm chi chq chw I T S F 03 00 00 00 ` 00 00 00
 0     F         Hxs      hxs hxi hxr hxq hxw lit I T O L I T L S 01 00 00 00 ( 00 00 00
 0               Iso      iso img       offset=32769 C D 0 0 1
 0     F G       Nsis     nsis          offset=4 EF BE AD DE N u l l s o f t I n s t
 0     F         Rar      rar r00       R a r ! 1A 07 00
 0     F         Rar5     rar r00       R a r ! 1A 07 01 00
 0 C      O   LH tar      tar ova       offset=257 u s t a r
 0        O      Udf      udf iso img   offset=32768 01 C D 0 0 1
 0 C SN       LH wim      wim swm esd ppkg M S W I M 00 00 00
 0 C   FMG       zip      zip z01 zipx jar xpi odt ods docx xlsx epub ipa apk appx P K 03 04  ||  P K 05 06  ||  P K 06 06  ||  P K 07 08 P K  ||  P K 0 0 P K

Codecs:
 0 4ED  303011B BCJ2
 0  ED  3030103 BCJ
 0  ED  3030205 PPC
 0  ED  3030401 IA64
 0  ED  3030501 ARM
 0  ED  3030701 ARMT
 0  ED  3030805 SPARC
 0  ED    20302 Swap2
 0  ED    20304 Swap4
 0  ED    40202 BZip2
 0  ED        0 Copy
 0  ED    40109 Deflate64
 0  ED    40108 Deflate
 0  ED        3 Delta
 0  ED       21 LZMA2
 0  ED    30101 LZMA
 0  ED    30401 PPMD
 0   D    40301 Rar1
 0   D    40302 Rar2
 0   D    40303 Rar3
 0   D    40305 Rar5
 0  ED  6F10701 7zAES
 0  ED  6F00181 AES256CBC

Hashers:
 0    4        1 CRC32
 0   20      201 SHA1
 0   32        A SHA256
 0    8        4 CRC64
 0   32      202 BLAKE2sp";
                return demoOutput.ToArrayOfLines();
            }
        }

        public static string[] Test
        {
            get
            {
                const string testOutput = @"
7-Zip 19.00 (x64) : Copyright (c) 1999-2018 Igor Pavlov : 2019-02-21

Scanning the drive for archives:
2 files, 2201618 bytes (2151 KiB)

Testing archive: foo.zip
ERROR: foo.zip
foo.zip
Open ERROR: Can not open the file as [zip] archive

ERRORS:
Is not archive

Testing archive: .\nested.zip
--
Path = .\nested.zip
Type = zip
Physical Size = 2198368

Everything is Ok

Archives: 2
OK archives: 1
Can't open as archive: 1
Files: 3
Size:       2359279
Compressed: 2198368";
                return testOutput.ToArrayOfLines();
            }
        }

        public static string[] Hash
        {
            get
            {
                const string hash = @"
7-Zip 19.00 (x64) : Copyright (c) 1999-2018 Igor Pavlov : 2019-02-21

Scanning
2 folders, 1 file, 1450 bytes (2 KiB)

CRC32    CRC64            SHA256                                                           SHA1            BLAKE2sp                                                                  Size  Name
-------- ---------------- ---------------------------------------------------------------- ---------------------------------------- ---------------------------------------------------------------- -------------  ------------
                                                                                            docs
                                                                                            docs\input
65F628E7 0C263A6A38541BE2 735E9C514689F10220846742C8871A665F5888D5C36F71F949C70D9B5FBBFBD6 30A96827A2BD56E1139FFA1988E53C6BDB400D5D 46569382381890A5F29264F0B7EA8EE3628C714911AE43839CC444490033BABD          1450  docs\input\index.cshtml
-------- ---------------- ---------------------------------------------------------------- ---------------------------------------- ---------------------------------------------------------------- -------------  ------------
65F628E7 0C263A6A38541BE2 735E9C514689F10220846742C8871A665F5888D5C36F71F949C70D9B5FBBFBD6 30A96827A2BD56E1139FFA1988E53C6BDB400D5D 46569382381890A5F29264F0B7EA8EE3628C714911AE43839CC444490033BABD          1450

Folders: 2
Files: 1
Size: 1450

CRC32  for data:              65F628E7
CRC32  for data and names:    DDEFD8B7

CRC64  for data:              0C263A6A38541BE2
CRC64  for data and names:    7914AFBA69DF8351

SHA256 for data:              735E9C514689F10220846742C8871A665F5888D5C36F71F949C70D9B5FBBFBD6
SHA256 for data and names:    22B8DE058E187C59B75D3E385864B8713E1A1D8315E137526E6BD069936B342A

SHA1   for data:              30A96827A2BD56E1139FFA1988E53C6BDB400D5D
SHA1   for data and names:    4B179021A00AE3AD7ACD2044212EF055CD31C6D8

BLAKE2sp for data:              46569382381890A5F29264F0B7EA8EE3628C714911AE43839CC444490033BABD
BLAKE2sp for data and names:    222855D590C06DE9B42BF15335DBC6EF14798938E202808A5C7DFE9BC38F8F25

Everything is Ok";

                return hash.ToArrayOfLines();
            }
        }
    }
}