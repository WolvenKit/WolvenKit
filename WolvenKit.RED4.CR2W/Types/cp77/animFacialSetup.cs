using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animFacialSetup : CResource
	{
		private rRef<animRig> _rig;
		private rRef<animRig> _inputRig;
		private animFacialSetup_BufferInfo _info;
		private animFacialSetup_PosesBufferInfo _posesInfo;
		private DataBuffer _bakedData;
		private DataBuffer _mainPosesData;
		private DataBuffer _correctivePosesData;
		private CArray<CName> _faceCorrectiveNames;
		private CArray<CName> _tongueCorrectiveNames;
		private CArray<CName> _eyesCorrectiveNames;
		private CArray<CUInt16> _usedTransformIndices;
		private CBool _useFemaleAnimSet;
		private CUInt32 _version;

		[Ordinal(1)] 
		[RED("rig")] 
		public rRef<animRig> Rig
		{
			get
			{
				if (_rig == null)
				{
					_rig = (rRef<animRig>) CR2WTypeManager.Create("rRef:animRig", "rig", cr2w, this);
				}
				return _rig;
			}
			set
			{
				if (_rig == value)
				{
					return;
				}
				_rig = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("inputRig")] 
		public rRef<animRig> InputRig
		{
			get
			{
				if (_inputRig == null)
				{
					_inputRig = (rRef<animRig>) CR2WTypeManager.Create("rRef:animRig", "inputRig", cr2w, this);
				}
				return _inputRig;
			}
			set
			{
				if (_inputRig == value)
				{
					return;
				}
				_inputRig = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("info")] 
		public animFacialSetup_BufferInfo Info
		{
			get
			{
				if (_info == null)
				{
					_info = (animFacialSetup_BufferInfo) CR2WTypeManager.Create("animFacialSetup_BufferInfo", "info", cr2w, this);
				}
				return _info;
			}
			set
			{
				if (_info == value)
				{
					return;
				}
				_info = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("posesInfo")] 
		public animFacialSetup_PosesBufferInfo PosesInfo
		{
			get
			{
				if (_posesInfo == null)
				{
					_posesInfo = (animFacialSetup_PosesBufferInfo) CR2WTypeManager.Create("animFacialSetup_PosesBufferInfo", "posesInfo", cr2w, this);
				}
				return _posesInfo;
			}
			set
			{
				if (_posesInfo == value)
				{
					return;
				}
				_posesInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("bakedData")] 
		public DataBuffer BakedData
		{
			get
			{
				if (_bakedData == null)
				{
					_bakedData = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "bakedData", cr2w, this);
				}
				return _bakedData;
			}
			set
			{
				if (_bakedData == value)
				{
					return;
				}
				_bakedData = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("mainPosesData")] 
		public DataBuffer MainPosesData
		{
			get
			{
				if (_mainPosesData == null)
				{
					_mainPosesData = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "mainPosesData", cr2w, this);
				}
				return _mainPosesData;
			}
			set
			{
				if (_mainPosesData == value)
				{
					return;
				}
				_mainPosesData = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("correctivePosesData")] 
		public DataBuffer CorrectivePosesData
		{
			get
			{
				if (_correctivePosesData == null)
				{
					_correctivePosesData = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "correctivePosesData", cr2w, this);
				}
				return _correctivePosesData;
			}
			set
			{
				if (_correctivePosesData == value)
				{
					return;
				}
				_correctivePosesData = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("faceCorrectiveNames")] 
		public CArray<CName> FaceCorrectiveNames
		{
			get
			{
				if (_faceCorrectiveNames == null)
				{
					_faceCorrectiveNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "faceCorrectiveNames", cr2w, this);
				}
				return _faceCorrectiveNames;
			}
			set
			{
				if (_faceCorrectiveNames == value)
				{
					return;
				}
				_faceCorrectiveNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("tongueCorrectiveNames")] 
		public CArray<CName> TongueCorrectiveNames
		{
			get
			{
				if (_tongueCorrectiveNames == null)
				{
					_tongueCorrectiveNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "tongueCorrectiveNames", cr2w, this);
				}
				return _tongueCorrectiveNames;
			}
			set
			{
				if (_tongueCorrectiveNames == value)
				{
					return;
				}
				_tongueCorrectiveNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("eyesCorrectiveNames")] 
		public CArray<CName> EyesCorrectiveNames
		{
			get
			{
				if (_eyesCorrectiveNames == null)
				{
					_eyesCorrectiveNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "eyesCorrectiveNames", cr2w, this);
				}
				return _eyesCorrectiveNames;
			}
			set
			{
				if (_eyesCorrectiveNames == value)
				{
					return;
				}
				_eyesCorrectiveNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("usedTransformIndices")] 
		public CArray<CUInt16> UsedTransformIndices
		{
			get
			{
				if (_usedTransformIndices == null)
				{
					_usedTransformIndices = (CArray<CUInt16>) CR2WTypeManager.Create("array:Uint16", "usedTransformIndices", cr2w, this);
				}
				return _usedTransformIndices;
			}
			set
			{
				if (_usedTransformIndices == value)
				{
					return;
				}
				_usedTransformIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("useFemaleAnimSet")] 
		public CBool UseFemaleAnimSet
		{
			get
			{
				if (_useFemaleAnimSet == null)
				{
					_useFemaleAnimSet = (CBool) CR2WTypeManager.Create("Bool", "useFemaleAnimSet", cr2w, this);
				}
				return _useFemaleAnimSet;
			}
			set
			{
				if (_useFemaleAnimSet == value)
				{
					return;
				}
				_useFemaleAnimSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get
			{
				if (_version == null)
				{
					_version = (CUInt32) CR2WTypeManager.Create("Uint32", "version", cr2w, this);
				}
				return _version;
			}
			set
			{
				if (_version == value)
				{
					return;
				}
				_version = value;
				PropertySet(this);
			}
		}

		public animFacialSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
