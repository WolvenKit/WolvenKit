using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animFacialSetup_OneSermoPoseBufferInfo : CVariable
	{
		private CUInt16 _numMainPoses;
		private CUInt16 _numCorrectivePoses;
		private CUInt32 _numMainTransforms;
		private CUInt32 _numMainScales;
		private CUInt32 _numCorrectiveTransforms;
		private CUInt32 _numCorrectiveScales;

		[Ordinal(0)] 
		[RED("numMainPoses")] 
		public CUInt16 NumMainPoses
		{
			get
			{
				if (_numMainPoses == null)
				{
					_numMainPoses = (CUInt16) CR2WTypeManager.Create("Uint16", "numMainPoses", cr2w, this);
				}
				return _numMainPoses;
			}
			set
			{
				if (_numMainPoses == value)
				{
					return;
				}
				_numMainPoses = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("numCorrectivePoses")] 
		public CUInt16 NumCorrectivePoses
		{
			get
			{
				if (_numCorrectivePoses == null)
				{
					_numCorrectivePoses = (CUInt16) CR2WTypeManager.Create("Uint16", "numCorrectivePoses", cr2w, this);
				}
				return _numCorrectivePoses;
			}
			set
			{
				if (_numCorrectivePoses == value)
				{
					return;
				}
				_numCorrectivePoses = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("numMainTransforms")] 
		public CUInt32 NumMainTransforms
		{
			get
			{
				if (_numMainTransforms == null)
				{
					_numMainTransforms = (CUInt32) CR2WTypeManager.Create("Uint32", "numMainTransforms", cr2w, this);
				}
				return _numMainTransforms;
			}
			set
			{
				if (_numMainTransforms == value)
				{
					return;
				}
				_numMainTransforms = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("numMainScales")] 
		public CUInt32 NumMainScales
		{
			get
			{
				if (_numMainScales == null)
				{
					_numMainScales = (CUInt32) CR2WTypeManager.Create("Uint32", "numMainScales", cr2w, this);
				}
				return _numMainScales;
			}
			set
			{
				if (_numMainScales == value)
				{
					return;
				}
				_numMainScales = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("numCorrectiveTransforms")] 
		public CUInt32 NumCorrectiveTransforms
		{
			get
			{
				if (_numCorrectiveTransforms == null)
				{
					_numCorrectiveTransforms = (CUInt32) CR2WTypeManager.Create("Uint32", "numCorrectiveTransforms", cr2w, this);
				}
				return _numCorrectiveTransforms;
			}
			set
			{
				if (_numCorrectiveTransforms == value)
				{
					return;
				}
				_numCorrectiveTransforms = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("numCorrectiveScales")] 
		public CUInt32 NumCorrectiveScales
		{
			get
			{
				if (_numCorrectiveScales == null)
				{
					_numCorrectiveScales = (CUInt32) CR2WTypeManager.Create("Uint32", "numCorrectiveScales", cr2w, this);
				}
				return _numCorrectiveScales;
			}
			set
			{
				if (_numCorrectiveScales == value)
				{
					return;
				}
				_numCorrectiveScales = value;
				PropertySet(this);
			}
		}

		public animFacialSetup_OneSermoPoseBufferInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
