using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;
using WolvenKit.Common;
using WolvenKit.Common.Model;

namespace WolvenKit.CR2W.SRT
{
    /// <summary>
    /// kinda wrong to make it inherit from cr2w but that way I can force it into a frmCr2wdocument 
    /// otherwise design a new form *sigh*
    /// better: have an IWitcherFile interface 
    /// </summary>
    public class Srtfile : ObservableObject, IWolvenkitFile
    {
        public Srtfile()
        {
            Extents = new CExtents();
            LodProfile = new SLodProfile();
            Wind = new CWind();

            //StringTable = new string[];
            //CollisionObjects = new SCollisionObject[];
            VerticalBillboards = new SVerticalBillboards();
            HorizontalBillboard = new SHorizontalBillboard();

            PUserStrings = new string[(int)EUserStringOrdinal.USER_STRING_COUNT];
            Geometry = new SGeometry();
        }



        #region Properties
        public CExtents Extents { get; set; }
        public SLodProfile LodProfile { get; set; }
        public CWind Wind { get; set; }
        

        public string[] StringTable { get; set; }
        public SCollisionObject[] CollisionObjects { get; set; }
        public SVerticalBillboards VerticalBillboards { get; set; }
        public SHorizontalBillboard HorizontalBillboard { get; set; }

        public string[] PUserStrings { get; set; }

        public SGeometry Geometry { get; set; }


        [Browsable(false)]
        public string FileName { get; set; }
        #endregion


        #region Fields
        private Stream m_stream;
        private bool m_bFileIsBigEndian;
        private bool m_bTexCoordsFlipped;
        private const int c_nSrtHeaderLength = 16;
        const string c_pSrtHeader = "SRT 07.0.0";
        const int c_nSizeOfInt = 4;
        const int c_nSizeOfFloat = 4;
        const int c_nFixedStringLength = 256;
        #endregion

        #region Read
        public EFileReadErrorCodes Read(BinaryReader br)
        {
            m_stream = br.BaseStream;


            if (ParseHeader(br) &&
                    ParsePlatform(br) &&
                    ParseExtents(br) &&
                    ParseLOD(br) &&
                    ParseWind(br))
            {
                if (ParseStringTable(br) &&
                    ParseCollisionObjects(br) &&
                    ParseBillboards(br) &&
                    ParseCustomData(br) &&
                    ParseRenderStates(br) &&
                    Parse3dGeometry(br))
                {
                    if (ParseVertexAndIndexData(br))
                    {
                        var remainingbytes = GetRemainingLength();
                        if (remainingbytes > 0)
                            Debugger.Break();
                    }
                }
            }

            return EFileReadErrorCodes.NoError;
        }

        private long GetRemainingLength() => m_stream.Length - m_stream.Position;

        #region Block 1
        ///////////////////////////////////////////////////////////////////////  
        //  CParser::ParseHeader

        private bool ParseHeader(BinaryReader br)
        {
            bool bSuccess = false;
            var startpos = br.BaseStream.Position;
            if (GetRemainingLength() >= c_nSrtHeaderLength)
            {
                // 16 bytes reserved
                string cHeader = Encoding.GetEncoding("ISO-8859-1").GetString(br.ReadBytes(16));
                if (cHeader.TrimEnd((char)0x00) == c_pSrtHeader)
                {
                    bSuccess = true;
                }
                //else
                //CCore::SetError("CParser::ParseHeader, expected header [%s] but got [%s]\n", c_pSrtHeader, cHeader.c_str());

                if (br.BaseStream.Position - startpos != c_nSrtHeaderLength)
                    throw new NotImplementedException();
            }
            //else
                //CCore::SetError("CParser::ParseHeader, premature end-of-file\n");

            return bSuccess;
        }

        ///////////////////////////////////////////////////////////////////////  
        //  CParser::ParsePlatform

        private bool ParsePlatform(BinaryReader br)
        {
            bool bSuccess = false;
            var startpos = br.BaseStream.Position;
            if (GetRemainingLength() >= 2 * c_nSizeOfInt)   // parser.cpp uses 2 * size_of_int, but actually only 4 bytes are read?
            {
                m_bFileIsBigEndian = (br.ReadByte() != 0);

                if (m_bFileIsBigEndian)
                    throw new NotImplementedException();

                // coordinate system
                int nCoordSysEnum = (int)(br.ReadByte());
                if (nCoordSysEnum != 0)
                    throw new NotImplementedException();

                // texcoords flipped flag
                m_bTexCoordsFlipped = (br.ReadByte() == 1);

                br.ReadByte();  // reserved

                bSuccess = true;
                if (br.BaseStream.Position - startpos !=  c_nSizeOfInt)     
                    throw new NotImplementedException();
            }
            //else
            //    CCore::SetError("CParser::ParsePlatform, premature end-of-file\n");

            return bSuccess;
        }

        ///////////////////////////////////////////////////////////////////////  
        //  CParser::ParseExtents

        private bool ParseExtents(BinaryReader br)
        {
            bool bSuccess = false;
            var startpos = br.BaseStream.Position;
            if (GetRemainingLength() >= 6 * c_nSizeOfFloat)
            {

                // min
                Extents.m_cExtents[0] = br.ReadSingle();
                Extents.m_cExtents[1] = br.ReadSingle();
                Extents.m_cExtents[2] = br.ReadSingle();

                // max
                Extents.m_cExtents[3] = br.ReadSingle();
                Extents.m_cExtents[4] = br.ReadSingle();
                Extents.m_cExtents[5] = br.ReadSingle();

                // make sure the mins are <= max values; if not, swap them
                Array.Sort(Extents.m_cExtents);

                bSuccess = true;
                if (br.BaseStream.Position - startpos != 6 * c_nSizeOfFloat)
                    throw new NotImplementedException();
            }
            //else
            //    CCore::SetError("CParser::ParseExtents, premature end-of-file\n");

            return bSuccess;
        }

        ///////////////////////////////////////////////////////////////////////  
        //  CParser::ParseLOD

        private bool ParseLOD(BinaryReader br)
        {
            bool bSuccess = false;
            var startpos = br.BaseStream.Position;
            if (GetRemainingLength() >= 1 * c_nSizeOfInt + 4 * c_nSizeOfFloat)
            {
                LodProfile.m_bLodIsPresent = (br.ReadInt32() != 0);
                LodProfile.m_fHighDetail3dDistance = br.ReadSingle();
                LodProfile.m_fLowDetail3dDistance = br.ReadSingle();
                LodProfile.m_fBillboardStartDistance = br.ReadSingle();
                LodProfile.m_fBillboardFinalDistance = br.ReadSingle();

                bSuccess = true;
                if (br.BaseStream.Position - startpos != 1 * c_nSizeOfInt + 4 * c_nSizeOfFloat)
                    throw new NotImplementedException();
            }
            //else
            //    CCore::SetError("CParser::ParseLOD, premature end-of-file\n");

            return bSuccess;
        }

        ///////////////////////////////////////////////////////////////////////  
        //  CParser::ParseWind

        private bool ParseWind(BinaryReader br)
        {
            bool bSuccess = false;
            var startpos = br.BaseStream.Position;
            if (GetRemainingLength() >= Marshal.SizeOf<CWind.SParams>())
            {
                try
                {
                    // parse wind params
                    CWind.SParams p = br.BaseStream.ReadStruct<CWind.SParams>();
                    Wind.Params = p;

                    if (br.BaseStream.Position - startpos != Marshal.SizeOf<CWind.SParams>())
                        throw new NotImplementedException();
                    startpos = br.BaseStream.Position;

                    // parse array of option bools
                    int optionsLength = (int)CWind.EOptions.NUM_WIND_OPTIONS;
                    if (GetRemainingLength() >= optionsLength)
                    {
                        bool[] options = new bool[optionsLength];
                        for (int i = 0; i < options.Length; i++)
                        {
                            options[i] = (br.ReadByte() != 0);
                        }
                        Wind.m_abOptions = options;
                        ParseUntilAligned(br);

                        if (br.BaseStream.Position - startpos != optionsLength)
                            throw new NotImplementedException();
                        startpos = br.BaseStream.Position;

                        // grab tree-specific values
                        if (GetRemainingLength() >= (3 + 1) * c_nSizeOfFloat)
                        {
                            // branch anchor
                            float[] vBranchAnchor = new float[3];
                            vBranchAnchor[0] = br.ReadSingle();
                            vBranchAnchor[1] = br.ReadSingle();
                            vBranchAnchor[2] = br.ReadSingle();

                            // max branch length
                            float fMaxBranchLength = br.ReadSingle();

                            // set values
                            Wind.m_afBranchWindAnchor = vBranchAnchor;
                            Wind.m_fMaxBranchLevel1Length = fMaxBranchLength;

                            bSuccess = true;
                            if (br.BaseStream.Position - startpos != (3 + 1) * c_nSizeOfFloat)
                                throw new NotImplementedException();
                        }

                    }
                }
                catch (Exception)
                {

                    bSuccess = false;
                }
            }
            //else
            //    CCore::SetError("CParser::ParseWind, premature end-of-file\n");

            return bSuccess;
        }
        #endregion

        #region Block 2
        ///////////////////////////////////////////////////////////////////////  
        //  CParser::ParseStringTable

        private bool ParseStringTable(BinaryReader br)
        {
            bool bSuccess = false;
            if (GetRemainingLength() >= c_nSizeOfInt)
            {
                var m_nNumStringsInTable = br.ReadInt32();
                if (GetRemainingLength() >= 256 * c_nSizeOfInt)
                {
                    // what's written here:
                    //
                    //	N = # strings (m_nNumStringsInTable above)
                    //
                    //	for each N
                    //		<padded string length>
                    //
                    //	<padded string length> =
                    //		<4-byte pad>
                    //		<4-byte length of string>
                    //
                    //	for each N
                    //		<characters of string>
                    //		<padded for alignment>

                    int[] stringlengths = new int[m_nNumStringsInTable];
                    for (int i = 0; i < m_nNumStringsInTable; i++)
                    {
                        var pad = br.ReadInt32();
                        var len = br.ReadInt32();
                        stringlengths[i] = len;
                    }

                    var strings = new string[m_nNumStringsInTable];
                    for (int i = 0; i < m_nNumStringsInTable; i++)
                    {
                        strings[i] = Encoding.GetEncoding("ISO-8859-1").GetString(br.ReadBytes(stringlengths[i])).TrimEnd((char)0x00);
                    }
                    StringTable = new string[strings.Length];
                    StringTable = strings;

                    bSuccess = true;
                }
            }
            //else
            //    CCore::SetError("CParser::ParseStringTable, premature end-of-file\n");

            return bSuccess;
        }

        ///////////////////////////////////////////////////////////////////////  
        //  CParser::ParseCollisionObjects

        private bool ParseCollisionObjects(BinaryReader br)
        {
            bool bSuccess = false;
            var startpos = br.BaseStream.Position;
            if (GetRemainingLength() >= c_nSizeOfInt)
            {
                var m_nNumCollisionObjects = br.ReadInt32();

                if (m_nNumCollisionObjects == 0)
                    return true;

                if (br.BaseStream.Position - startpos != c_nSizeOfInt)
                    throw new NotImplementedException();
                startpos = br.BaseStream.Position;

                if (GetRemainingLength() >= m_nNumCollisionObjects * Marshal.SizeOf<SCollisionObject>())
                {
                    CollisionObjects = new SCollisionObject[m_nNumCollisionObjects];
                    for (int i = 0; i < m_nNumCollisionObjects; i++)
                    {
                        CollisionObjects[i] = br.BaseStream.ReadStruct<SCollisionObject>();
                    }

                    bSuccess = true;
                    if (br.BaseStream.Position - startpos != m_nNumCollisionObjects * Marshal.SizeOf<SCollisionObject>())
                        throw new NotImplementedException();
                }

            }
            //else
            //    CCore::SetError("CParser::ParseCollisionObjects, premature end-of-file\n");

            return bSuccess;
        }


        ///////////////////////////////////////////////////////////////////////  
        //  CParser::ParseBillboards

        private bool ParseBillboards(BinaryReader br)
        {
            bool bSuccess = false;
            var startpos = br.BaseStream.Position;

            // vertical billboards
            if (GetRemainingLength() >= 2 * c_nSizeOfInt + 3 * c_nSizeOfFloat)
            {
                SVerticalBillboards sBBs = new SVerticalBillboards();

                // parse dimensions
                sBBs.FWidth = br.ReadSingle();
                sBBs.FTopPos = br.ReadSingle();
                sBBs.FBottomPos = br.ReadSingle();
                sBBs.NNumBillboards = br.ReadInt32();

                // texcoord table
                if (m_stream.Position % 4 != 0) throw new NotImplementedException(); // check alignment
                sBBs.PTexCoords = new float[sBBs.NNumBillboards * 4];
                for (int i = 0; i < sBBs.NNumBillboards * 4; i++)
                {
                    sBBs.PTexCoords[i] = br.ReadSingle();
                    //sBBs.PTexCoords[1] = br.ReadSingle();
                    //sBBs.PTexCoords[2] = br.ReadSingle();
                    //sBBs.PTexCoords[3] = br.ReadSingle();
                }

                // rotated flags
                sBBs.PRotated = new byte[sBBs.NNumBillboards];
                for (int i = 0; i < sBBs.NNumBillboards; i++)
                {
                    sBBs.PRotated[i] = br.ReadByte();
                }
                ParseUntilAligned(br);

                // cutout values
                sBBs.NNumCutoutVertices = br.ReadInt32();
                sBBs.NNumCutoutIndices = br.ReadInt32();
                if (sBBs.NNumCutoutVertices > 0 && sBBs.NNumCutoutIndices > 0)
                {
                    // interp float pairs
                    sBBs.PCutoutVertices = new float[2 * sBBs.NNumCutoutVertices];
                    for (int i = 0; i < (2 * sBBs.NNumCutoutVertices); i++)
                    {
                        sBBs.PCutoutVertices[i] = br.ReadSingle();
                    }

                    // interp indices
                    sBBs.PCutoutIndices = new ushort[sBBs.NNumCutoutIndices];
                    for (int i = 0; i < sBBs.NNumCutoutIndices; i++)
                    {
                        sBBs.PCutoutIndices[i] = br.ReadUInt16();
                    }
                    ParseUntilAligned(br);
                }

                VerticalBillboards = sBBs;
                bSuccess = true;

                //if (br.BaseStream.Position - startpos != 2 * c_nSizeOfInt + 3 * c_nSizeOfFloat)
                //    throw new NotImplementedException();
            }
            //else
            //    CCore::SetError("CParser::ParseBillboards, premature end-of-file\n");


            // horizontal billboards
            startpos = br.BaseStream.Position;
            if (GetRemainingLength() >= c_nSizeOfInt + (8 + 12) * c_nSizeOfFloat)
            {
                var sbb = new SHorizontalBillboard();
                sbb.BPresent = (br.ReadInt32() != 0);

                // texcoords
                sbb.AfTexCoords = new float[8];
                for (int i = 0; i < 8; i++)
                {
                    sbb.AfTexCoords[i] = br.ReadSingle();
                }

                // positions
                sbb.AvPositions = new Vec3[4];
                for (int i = 0; i < 4; i++)
                {
                    Vec3 vec = br.BaseStream.ReadStruct<Vec3>();
                    sbb.AvPositions[i] = vec;
                }
                HorizontalBillboard = sbb;

                if (br.BaseStream.Position - startpos != c_nSizeOfInt + (8 + 12) * c_nSizeOfFloat)
                    throw new NotImplementedException();
            }
            else
                bSuccess = false;
            //    CCore::SetError("CParser::ParseBillboards, premature end-of-file\n");

            return bSuccess;
        }


        ///////////////////////////////////////////////////////////////////////  
        //  CParser::ParseCustomData

        private bool ParseCustomData(BinaryReader br)
        {
            bool bSuccess = false;
            var startpos = br.BaseStream.Position;
            if (GetRemainingLength() >= c_nSizeOfInt * (int)EUserStringOrdinal.USER_STRING_COUNT)
            {
                bSuccess = true;
                for (int i = 0; i < (int)EUserStringOrdinal.USER_STRING_COUNT; i++)
                {
                    int idx = br.ReadInt32();
                    PUserStrings[i] = StringTable[idx];
                }

                if (br.BaseStream.Position - startpos != c_nSizeOfInt * (int)EUserStringOrdinal.USER_STRING_COUNT)
                    throw new NotImplementedException();
            }
            //else
            //    CCore::SetError("CParser::ParseCustomData, premature end-of-file\n");

            return bSuccess;
        }

        ///////////////////////////////////////////////////////////////////////  
        //  CParser::ParseRenderStates

        private bool ParseRenderStates(BinaryReader br)
        {
            bool bSuccess = false;
            var startpos = br.BaseStream.Position;
            if (GetRemainingLength() >= 3 * c_nSizeOfInt)
            {
                Geometry.NNum3dRenderStates = br.ReadInt32();
                Geometry.BDepthOnlyIncluded = (br.ReadInt32() == 1);
                Geometry.BShadowCastIncluded = (br.ReadInt32() == 1);

                // parse shader path
                Geometry.StrShaderPath = StringTable[br.ReadInt32()];


                // parse 3d lighting render states
                Geometry.P3dRenderStateMain = new SRenderState[Geometry.NNum3dRenderStates];
                Geometry.P3dRenderStateDepth = new SRenderState[Geometry.NNum3dRenderStates];
                Geometry.P3dRenderStateShadow = new SRenderState[Geometry.NNum3dRenderStates];
                Geometry.ABillboardRenderStateMain = new SRenderState();
                Geometry.ABillboardRenderStateDepth = new SRenderState();
                Geometry.ABillboardRenderStateShadow = new SRenderState();

                bSuccess = ParseRenderStateBlock(ERenderPass.RENDER_PASS_MAIN, Geometry.NNum3dRenderStates, br);

                // parse 3d depth-only render states
                if (Geometry.BDepthOnlyIncluded)
                    bSuccess &= ParseRenderStateBlock(ERenderPass.RENDER_PASS_DEPTH_PREPASS, Geometry.NNum3dRenderStates, br);

                // parse 3d shadow cast render states
                if (Geometry.BShadowCastIncluded)
                    bSuccess &= ParseRenderStateBlock(ERenderPass.RENDER_PASS_SHADOW_CAST, Geometry.NNum3dRenderStates, br);

                // billboard lighting render state
                bSuccess &= ParseAndCopyRenderState(ERenderPass.RENDER_PASS_MAIN, br);

                // billboard depth-only render state
                if (Geometry.BDepthOnlyIncluded)
                    bSuccess &= ParseAndCopyRenderState(ERenderPass.RENDER_PASS_DEPTH_PREPASS, br);

                // billboard shadow cast render state
                if (Geometry.BShadowCastIncluded)
                    bSuccess &= ParseAndCopyRenderState(ERenderPass.RENDER_PASS_SHADOW_CAST, br);


            }
            //else
            //    CCore::SetError("CParser::ParseRenderStates, premature end-of-file\n");

            return bSuccess;
        }

        ///////////////////////////////////////////////////////////////////////  
        //  CParser::ParseRenderStateBlock

        bool ParseRenderStateBlock(ERenderPass blockid, int nNumStates, BinaryReader br)
        {
            bool bSuccess = false;
            var startpos = m_stream.Position;
            var t = Marshal.SizeOf<SRenderState>();
            if (GetRemainingLength() >= 720 * nNumStates)
            {
                for (int i = 0; i < nNumStates; i++)
                {
                    switch (blockid)
                    {
                        case ERenderPass.RENDER_PASS_MAIN:
                            Geometry.P3dRenderStateMain[i].Read(br, StringTable.ToList());
                            break;
                        case ERenderPass.RENDER_PASS_DEPTH_PREPASS:
                            Geometry.P3dRenderStateDepth[i].Read(br, StringTable.ToList());
                            break;
                        case ERenderPass.RENDER_PASS_SHADOW_CAST:
                            Geometry.P3dRenderStateShadow[i].Read(br, StringTable.ToList());
                            break;
                        default:
                            break;
                    }
                }

                if (m_stream.Position - startpos != 720 * nNumStates)
                    throw new NotImplementedException();
                bSuccess = true;
            }
            //else
            //    CCore::SetError("CParser::ParseRenderStateBlock, premature end-of-file\n");

            return bSuccess;
        }

        ///////////////////////////////////////////////////////////////////////  
        //  CParser::ParseAndCopyRenderState

        bool ParseAndCopyRenderState(ERenderPass blockid, BinaryReader br)
        {
            bool bSuccess = false;
            var startpos = m_stream.Position;
            if (GetRemainingLength() >= /*Marshal.SizeOf<SRenderState>()*/720)
            {
                switch (blockid)
                {
                    case ERenderPass.RENDER_PASS_MAIN:
                        var temp_renderstatem = new SRenderState();
                        temp_renderstatem.Read(br, StringTable.ToList());
                        Geometry.ABillboardRenderStateMain = temp_renderstatem;
                        break;
                    case ERenderPass.RENDER_PASS_DEPTH_PREPASS:
                        var temp_renderstated = new SRenderState();
                        temp_renderstated.Read(br, StringTable.ToList());
                        Geometry.ABillboardRenderStateDepth = temp_renderstated;
                        break;
                    case ERenderPass.RENDER_PASS_SHADOW_CAST:
                        var temp_renderstates = new SRenderState();
                        temp_renderstates.Read(br, StringTable.ToList());
                        Geometry.ABillboardRenderStateShadow = temp_renderstates;
                        break;
                    default:
                        break;
                }

                if (m_stream.Position - startpos != /*Marshal.SizeOf<SRenderState>()*/720)
                    throw new NotImplementedException();
                bSuccess = true;
            }
            //else
            //    CCore::SetError("CParser::ParseAndCopyRenderState, premature end-of-file\n");

            return bSuccess;
        }


        ///////////////////////////////////////////////////////////////////////  
        //  CParser::Parse3dGeometry

        private bool Parse3dGeometry(BinaryReader br)
        {
            bool bSuccess = false;

            // start with SLods
            if (GetRemainingLength() >= c_nSizeOfInt)
            {
                Geometry.NNumLods = br.ReadInt32();

                //if (GetRemainingLength() >= Geometry.NNumLods * Marshal.SizeOf<SLod>())
                if (GetRemainingLength() >= Geometry.NNumLods * 24)
                {
                    // read SLod structs
                    // reads NNumDrawCalls and m_nNumBones, the pointers are actually just 0 in the serialized file and get assigend upon parsing
                    Geometry.PLods = new SLod[Geometry.NNumLods];
                    for (int i = 0; i < Geometry.NNumLods; i++)
                    {
                        //Geometry.PLods[i] = ReadStruct<SLod>();
                        // I'm deviating here from the c++ parser bc they work with pointers
                        // but since the serialized pointer data is just null bytes that's fine

                        SLod lod = new SLod();
                        lod.NNumDrawCalls = br.ReadInt32();     
                        br.ReadBytes(8);                        // CDrawCallPointer 
                        lod.NNumBones = br.ReadInt32();         
                        br.ReadBytes(8);                        // CBonePointer 

                        Geometry.PLods[i] = lod;
                    }

                    // read SDrawCalls
                    for (int i = 0; i < Geometry.NNumLods; i++)
                    {
                        SLod plod = Geometry.PLods[i];

                        //if (GetRemainingLength() >= plod.NNumDrawCalls * Marshal.SizeOf<SDrawCall>())
                        if (GetRemainingLength() >= plod.NNumDrawCalls * 40)
                        {
                            plod.PDrawCalls = new SDrawCall[plod.NNumDrawCalls];
                            for (int j = 0; j < plod.NNumDrawCalls; j++)
                            {
                                //plod.PDrawCalls[j] = ReadStruct<SDrawCall>();
                                // again I'm deviating here from the c++ parser bc they work with pointers
                                // read the class manually
                                SDrawCall drawCall = new SDrawCall();
                                br.ReadBytes(8);                                // CRenderStatePointer m_pRenderState
                                drawCall.NRenderStateIndex = br.ReadInt32();
                                drawCall.NNumVertices = br.ReadInt32();
                                br.ReadBytes(8);                                // CBytePointer m_pVertexData
                                drawCall.NNumIndices = br.ReadInt32();
                                drawCall.B32BitIndices = br.ReadBytes(4).First() != 0x00;
                                br.ReadBytes(8);                                // CBytePointer m_pIndexData
                                plod.PDrawCalls[j] = drawCall;

                                // read bones
                                if (plod.NNumBones > 0)
                                {
                                    plod.PBones = new SBone[plod.NNumBones];
                                    for (int k = 0; k < plod.NNumBones; i++)
                                    {
                                        plod.PBones[k] = br.BaseStream.ReadStruct<SBone>();
                                    }
                                }
                            }

                            // assign draw calls' render state pointers
                            for (int ndrawcall = 0; ndrawcall < plod.NNumDrawCalls; ndrawcall++)
                            {
                                SDrawCall pDrawCall = plod.PDrawCalls[ndrawcall];
                                pDrawCall.PRenderState = Geometry.P3dRenderStateMain[pDrawCall.NRenderStateIndex];
                            }
                        }
                    }
                    bSuccess = true;
                }

            }
            //else
            //    CCore::SetError("CParser::Parse3dGeometry, premature end-of-file\n");

            return bSuccess;
        }
        #endregion

        #region Block 3
        ///////////////////////////////////////////////////////////////////////  
        //  CParser::ParseVertexAndIndexData

        private bool ParseVertexAndIndexData(BinaryReader br)
        {
            bool bSuccess = false;

            if (Geometry == null)
                return false;

            for (int i = 0; i < Geometry.NNumLods; i++)
            {
                if (Geometry.PLods == null)
                    return false;
                SLod lod = Geometry.PLods[i];
                if (lod == null)
                    return false;

                for (int j = 0; j < lod.NNumDrawCalls; j++)
                {
                    if (lod.PDrawCalls == null)
                        return false;
                    SDrawCall pDrawCall = lod.PDrawCalls[j];
                    if (pDrawCall == null)
                        return false;

                    int uiVertexDataSize = pDrawCall.NNumVertices * pDrawCall.PRenderState.SVertexDecl.UiVertexSize;
                    int uiIndexDataSize = pDrawCall.NNumIndices * (pDrawCall.B32BitIndices ? 4 : 2);

                    if (GetRemainingLength() >= uiVertexDataSize + uiIndexDataSize)
                    {
                        // vertex data
                        if (m_stream.Position % 4 != 0)
                            return false;
                        pDrawCall.PVertexData = br.ReadBytes(uiVertexDataSize);

                        // index data
                        if (m_stream.Position % 4 != 0)
                            return false;
                        pDrawCall.PIndexData = br.ReadBytes(uiIndexDataSize);

                        ParseUntilAligned(br);
                    }
                    //else
                    //    CCore::SetError("CParser::ParseVertexAndIndexData, premature end-of-file\n");
                }
            }
            bSuccess = true;


            //else
            //    CCore::SetError("CParser::ParseVertexAndIndexData, premature end-of-file\n");

            return bSuccess;
        }
        #endregion
        #endregion

        #region Write

        public void Write(BinaryWriter file)
        {
            if (WriteHeader(file) &&
                    WritePlatform(file) &&
                    WriteExtents(file) &&
                    WriteLOD(file) &&
                    WriteWind(file))
            {
                if (WriteStringTable(file) &&
                    WriteCollisionObjects(file) &&
                    WriteBillboards(file) &&
                    WriteCustomData(file) &&
                    WriteRenderStates(file) &&
                    Write3dGeometry(file))
                {
                    if (WriteVertexAndIndexData(file))
                    { }
                }
            }

        }

        private bool WriteVertexAndIndexData(BinaryWriter file)
        {
            for (int i = 0; i < Geometry.NNumLods; i++)
            {
                for (int j = 0; j < Geometry.PLods[i].NNumDrawCalls; j++)
                {
                    file.Write(Geometry.PLods[i].PDrawCalls[j].PVertexData);
                    file.Write(Geometry.PLods[i].PDrawCalls[j].PIndexData);
                }
            }


            return true;
        }

        private bool Write3dGeometry(BinaryWriter file)
        {
            file.Write(Geometry.NNumLods);
            for (int i = 0; i < Geometry.NNumLods; i++)
            {
                file.Write(Geometry.PLods[i].NNumDrawCalls);
                file.Write(new byte[8]);
                file.Write(Geometry.PLods[i].NNumBones);
                file.Write(new byte[8]);
            }
            for (int i = 0; i < Geometry.NNumLods; i++)
            {
                for (int j = 0; j < Geometry.PLods[i].NNumDrawCalls; j++)
                {
                    file.Write(new byte[8]);
                    file.Write(Geometry.PLods[i].PDrawCalls[j].NRenderStateIndex);
                    file.Write(Geometry.PLods[i].PDrawCalls[j].NNumVertices);
                    file.Write(new byte[8]);
                    file.Write(Geometry.PLods[i].PDrawCalls[j].NNumIndices);
                    file.Write(Geometry.PLods[i].PDrawCalls[j].B32BitIndices);
                    file.WriteUntilAligned();
                    file.Write(new byte[8]);
                }
                if (Geometry.PLods[i].NNumBones > 0)
                {
                    for (int k = 0; k < Geometry.PLods[i].NNumBones; i++)
                    {
                        file.BaseStream.WriteStruct<SBone>(Geometry.PLods[i].PBones[k]);
                    }
                }
            }

            return true;
        }

        private bool WriteRenderStates(BinaryWriter file)
        {
            file.Write(Geometry.NNum3dRenderStates);
            file.Write(Geometry.BDepthOnlyIncluded ? (int)1 : (int)0);
            file.Write(Geometry.BShadowCastIncluded ? (int)1 : (int)0);
            int id = 0;
            for (int j = 0; j < StringTable.Length; j++)
            {
                if (StringTable[j] == Geometry.StrShaderPath)
                {
                    id = j;
                    break;
                }
            }
            file.Write(id);
            for (int i = 0; i < Geometry.NNum3dRenderStates; i++)
            {
                Geometry.P3dRenderStateMain[i].Write(file, StringTable.ToList());
            }
            if (Geometry.BDepthOnlyIncluded)
                for (int i = 0; i < Geometry.NNum3dRenderStates; i++)
                {
                    Geometry.P3dRenderStateDepth[i].Write(file, StringTable.ToList());
                }
            if (Geometry.BShadowCastIncluded)
                for (int i = 0; i < Geometry.NNum3dRenderStates; i++)
                {
                    Geometry.P3dRenderStateShadow[i].Write(file, StringTable.ToList());
                }


            Geometry.ABillboardRenderStateMain.Write(file, StringTable.ToList());
            if (Geometry.BDepthOnlyIncluded)
                Geometry.ABillboardRenderStateDepth.Write(file, StringTable.ToList());

            if (Geometry.BShadowCastIncluded)
                Geometry.ABillboardRenderStateShadow.Write(file, StringTable.ToList());

            return true;
        }

        private bool WriteCustomData(BinaryWriter file)
        {
            for (int i = 0; i < (int)EUserStringOrdinal.USER_STRING_COUNT; i++)
            {
                int id = 0;
                for (int j = 0; j < StringTable.Length; j++)
                {
                    if (StringTable[j] == PUserStrings[i])
                    {
                        id = j;
                        break;
                    }
                }
                file.Write(id);
            }
            return true;
        }

        private bool WriteBillboards(BinaryWriter file)
        {
            // parse dimensions
            file.Write(VerticalBillboards.FWidth);
            file.Write(VerticalBillboards.FTopPos);
            file.Write(VerticalBillboards.FBottomPos);
            file.Write(VerticalBillboards.NNumBillboards);

            for (int i = 0; i < VerticalBillboards.PTexCoords.Length; i++)
            {
                file.Write(VerticalBillboards.PTexCoords[i]);
            }
            for (int i = 0; i < VerticalBillboards.PRotated.Length; i++)
            {
                file.Write(VerticalBillboards.PRotated[i]);
            }
            file.WriteUntilAligned();

            file.Write(VerticalBillboards.PCutoutVertices.Length);
            file.Write(VerticalBillboards.PCutoutIndices.Length);
            for (int i = 0; i < VerticalBillboards.PCutoutVertices.Length; i++)
            {
                file.Write(VerticalBillboards.PCutoutVertices[i]);
            }

            for (int i = 0; i < VerticalBillboards.PCutoutIndices.Length; i++)
            {
                file.Write(VerticalBillboards.PCutoutIndices[i]);
            }
            file.WriteUntilAligned();


            file.Write(HorizontalBillboard.BPresent ? (int)1 : (int)0);

            // texcoords
            for (int i = 0; i < 8; i++)
            {
                file.Write(HorizontalBillboard.AfTexCoords[i]);
            }

            // positions
            for (int i = 0; i < 4; i++)
            {
                file.BaseStream.WriteStruct<Vec3>(HorizontalBillboard.AvPositions[i]);
            }

            return true;
        }

        private bool WriteCollisionObjects(BinaryWriter file)
        {
            if (CollisionObjects == null)
            {
                file.Write(0x00);
                return true;
            }
            file.Write(CollisionObjects.Length);
            for (int i = 0; i < CollisionObjects.Length; i++)
            {
                file.BaseStream.WriteStruct<SCollisionObject>(CollisionObjects[i]);
            }

            return true;
        }

        private bool WriteStringTable(BinaryWriter file)
        {
            if (StringTable == null)
                return true;
            file.Write(StringTable.Length);
            for (int i = 0; i < StringTable.Length; i++)
            {
                file.Write((int)0);
                var len2 = Encoding.GetEncoding("ISO-8859-1").GetBytes(StringTable[i]).Length + 1;
                var pad = 4 - len2 % 4;
                if (pad < 4)
                    len2 += pad;
                file.Write(len2);
            }
            for (int i = 0; i < StringTable.Length; i++)
            {
                file.Write(Encoding.GetEncoding("ISO-8859-1").GetBytes(StringTable[i]));
                file.Write((byte)0x00);
                file.WriteUntilAligned();
            }
            return true;
        }

        private bool WriteWind(BinaryWriter file)
        {
            if (Wind == null)
                return true;
            file.BaseStream.WriteStruct<CWind.SParams>(Wind.Params);

            for (int i = 0; i < Wind.m_abOptions.Length; i++)
            {
                file.Write(Wind.m_abOptions[i]);
            }
            file.WriteUntilAligned();

            for (int i = 0; i < Wind.m_afBranchWindAnchor.Length; i++)
            {
                file.Write(Wind.m_afBranchWindAnchor[i]);
            }

            file.Write(Wind.m_fMaxBranchLevel1Length);

            return true;
        }

        private bool WriteLOD(BinaryWriter file)
        {
            if (LodProfile == null)
                return true;
            file.Write(LodProfile.m_bLodIsPresent ? (int)1 : (int)0);
            file.Write(LodProfile.m_fHighDetail3dDistance);
            file.Write(LodProfile.m_fLowDetail3dDistance);
            file.Write(LodProfile.m_fBillboardStartDistance);
            file.Write(LodProfile.m_fBillboardFinalDistance);
            return true;
        }

        private bool WriteExtents(BinaryWriter file)
        {
            if (Extents == null)
                return true;
            Extents.Write(file);
            return true;
        }

        private bool WritePlatform(BinaryWriter file)
        {
            file.Write((byte)0x00);
            file.Write((byte)0x00);
            file.Write((byte)0x00);
            file.Write((byte)0x00);

            return true;
        }

        private bool WriteHeader(BinaryWriter file)
        {
            file.Write(c_pSrtHeader);
            file.Write(new byte[15 - c_pSrtHeader.Length]);

            return true;
        }
        #endregion


        #region Enums
        // user data
        enum EUserStringOrdinal
        {
            USER_STRING_0,
            USER_STRING_1,
            USER_STRING_2,
            USER_STRING_3,
            USER_STRING_4,
            USER_STRING_COUNT
        }


        #endregion

        private void ParseUntilAligned(BinaryReader br)
        {
            // read padding
            int uiPadSize = 4 - (int)m_stream.Position % 4;
            if (uiPadSize < 4)
                br.ReadBytes(uiPadSize);
        }

        public void SerializeToXml(Stream writer)
        {

        }

        

    }
}
