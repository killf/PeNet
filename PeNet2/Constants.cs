﻿using System;

namespace PeNet
{
    public class Constants
    {
        //////////////////////////////
        // IMAGE_FILE_HEADER constants
        //////////////////////////////

        // Machine
        public const UInt16 IMAGE_FILE_MACHINE_UNKNOWN      = 0x0;
        public const UInt16 IMAGE_FILE_MACHINE_I386         = 0x14c;
        public const UInt16 IMAGE_FILE_MACHINE_R3000        = 0x162;
        public const UInt16 IMAGE_FILE_MACHINE_R4000        = 0x166;
        public const UInt16 IMAGE_FILE_MACHINE_R10000       = 0x168;
        public const UInt16 IMAGE_FILE_MACHINE_WCEMIPSV2    = 0x169;
        public const UInt16 IMAGE_FILE_MACHINE_ALPHA        = 0x184;
        public const UInt16 IMAGE_FILE_MACHINE_SH3          = 0x1a2;
        public const UInt16 IMAGE_FILE_MACHINE_SH3DSP       = 0x1a3;
        public const UInt16 IMAGE_FILE_MACHINE_SH3E         = 0x1a4;
        public const UInt16 IMAGE_FILE_MACHINE_SH4          = 0x1a6;
        public const UInt16 IMAGE_FILE_MACHINE_SH5          = 0x1a8;
        public const UInt16 IMAGE_FILE_MACHINE_ARM          = 0x1c0;
        public const UInt16 IMAGE_FILE_MACHINE_THUMB        = 0x1c2;
        public const UInt16 IMAGE_FILE_MACHINE_AM33         = 0x1d3;
        public const UInt16 IMAGE_FILE_MACHINE_POWERPC      = 0x1f0;
        public const UInt16 IMAGE_FILE_MACHINE_POWERPCFP    = 0x1f1;
        public const UInt16 IMAGE_FILE_MACHINE_IA64         = 0x200;
        public const UInt16 IMAGE_FILE_MACHINE_MIPS16       = 0x266;
        public const UInt16 IMAGE_FILE_MACHINE_M68K         = 0x268;
        public const UInt16 IMAGE_FILE_MACHINE_ALPHA64      = 0x284;
        public const UInt16 IMAGE_FILE_MACHINE_MIPSFPU      = 0x366;
        public const UInt16 IMAGE_FILE_MACHINE_MIPSFPU16    = 0x466;
        public const UInt16 IMAGE_FILE_MACHINE_AXP64        = IMAGE_FILE_MACHINE_ALPHA64;
        public const UInt16 IMAGE_FILE_MACHINE_TRICORE      = 0x520;
        public const UInt16 IMAGE_FILE_MACHINE_CEF          = 0xcef;
        public const UInt16 IMAGE_FILE_MACHINE_EBC          = 0xebc;
        public const UInt16 IMAGE_FILE_MACHINE_AMD64        = 0x8664;
        public const UInt16 IMAGE_FILE_MACHINE_M32R         = 0x9041;
        public const UInt16 IMAGE_FILE_MACHINE_CEE          = 0xc0ee;

        // Characteristics
        public const UInt16 IMAGE_FILE_RELOCS_STRIPPED      = 0x01;
        public const UInt16 IMAGE_FILE_EXECUTABLE_IMAGE     = 0x02;
        public const UInt16 IMAGE_FILE_LINE_NUMS_STRIPPED   = 0x04;
        public const UInt16 IMAGE_FILE_LOCAL_SYMS_STRIPPED  = 0x08;
        public const UInt16 IMAGE_FILE_LARGE_ADDRESS_AWARE  = 0x20;
        public const UInt16 IMAGE_FILE_32BIT_MACHINE        = 0x100;
        public const UInt16 IMAGE_FILE_DEBUG_STRIPPED       = 0x200;
        public const UInt16 IMAGE_FILE_DLL                  = 0x2000;

        //////////////////////////
        // IMAGE_OPTIONAL_HEADER
        //////////////////////////

        // Magic
        public const UInt16 IMAGE_NT_OPTIONAL_HDR32_MAGIC = 0x10b;
        public const UInt16 IMAGE_NT_OPTIONAL_HDR64_MAGIC = 0x20b;
        
        // Subsystem
        public const UInt16 IMAGE_SUBSYSTEM_NATIVE      = 0x01; // driver
        public const UInt16 IMAGE_SUBSYSTEM_WINDOWS_GUI = 0x02;
        public const UInt16 IMAGE_SUBSYSTEM_WINDOWS_CUI = 0x03; // console
        
        // DllCharacteristics
        public const UInt16 IMAGE_DLLCHARACTERISTICS_DYNAMIC_BASE   = 0x40; // ASLR
        public const UInt16 IMAGE_DLLCHARACTERISTICS_NX_COMPAT      = 0x100; // DEP
        public const UInt16 IMAGE_DLLCHARACTERISTICS_NO_SEH         = 0x400;
        public const UInt16 IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE = 0x800;

        ////////////////////////
        // IMAGE_SECTION_HEADER
        ////////////////////////

        // Characteristics
        public const UInt32 IMAGE_SCN_CNT_CODE                  = 0x20;
        public const UInt32 IMAGE_SCN_CNT_INITIALIZED_DATA      = 0x40;
        public const UInt32 IMAGE_SCN_CNT_UNINITIALIZED_DATA    = 0x80;
        public const UInt32 IMAGE_SCN_MEM_DISCARDABLE           = 0x02000000;
        public const UInt32 IMAGE_SCN_MEM_SHARED                = 0x10000000;
        public const UInt32 IMAGE_SCN_MEM_EXECUTE               = 0x20000000;
        public const UInt32 IMAGE_SCN_MEM_READ                  = 0x40000000;
        public const UInt32 IMAGE_SCN_MEM_WRITE                 = 0x80000000;


        //////////////////////////////////
        // IMAGE_RESOURCE_DIRECTORY_ENTRY
        //////////////////////////////////

        // Group IDs
        public enum ResourceGroupIDs : ushort
        {
            Cursor = 1,
            Bitmap = 2,
            Icon = 3,
            Menu = 4,
            Dialog = 5,
            String = 6,
            FontDirectory = 7,
            Fonst = 8,
            Accelerator = 9,
            RcData = 10,
            MessageTable = 11,
            Version = 16,
            DlgInclude = 17,
            PlugAndPlay = 19,
            VXD = 20,
            AnimatedCurser = 21,
            AnimatedIcon = 22,
            HTML = 23,
            Manifest = 24
        }

        ////////////////////////
        // IMAGE_DATA_DIRECTORY
        ////////////////////////

        // Different data directories indices
        public enum DataDirectoryIndex
        {
            Export = 0,     // Export directory
            Import = 1,     // Import directory
            Resource = 2,   // Resource directory
            Exception = 3,
            Security = 4,
            BaseReloc = 5,
            Debug = 6,
            Copyright = 7,  // Useless
            Globalptr = 8,  // Only interesting for Itanium systems
            TLS = 9,
            LoadConfig = 0xA,
            BoundImport = 0xB,
            IAT = 0xC,
            DelayImport = 0xD,
            COM_Descriptor = 0xE, // .Net Header
            Reserved = 0xF
        }

        /////////////////
        // UNWINDE_CODE
        /////////////////

        // UnwindOp Codes
        public enum UnwindOpCodes : byte
        {
            UWOP_PUSH_NONVOL = 0,
            UWOP_ALLOC_LARGE = 1,
            UWOP_ALLOC_SMALL = 2,
            UWOP_SET_FPREG = 3,
            UWOP_SAVE_NONVOL = 4,
            UWOP_SAVE_NONVOL_FAR = 5,
            UWOP_SAVE_XMM128 = 8,
            UWOP_SAVE_XMM128_FAR = 9,
            UWOP_PUSH_MACHFRAME = 10,
        }

        //////////////////////////////////////
        // WIN_CERTIFICATE wCertificateType
        //////////////////////////////////////

        public const UInt16 WIN_CERT_TYPE_X509 = 0x0001;
        public const UInt16 WIN_CERT_TYPE_PKCS_SIGNED_DATA = 0x0002;
        public const UInt16 WIN_CERT_TYPE_RESERVED_1 = 0x0003;
        public const UInt16 WIN_CERT_TYPE_PKCS1_SIGN = 0x0009;

    }
}
