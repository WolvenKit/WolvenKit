using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFallbackFrameDesc : CVariable
	{
		private CUInt16 _rsion;
		private CUInt16 _pe;
		private CUInt16 _mPositions;
		private CUInt16 _mRotations;

		[Ordinal(0)] 
		[RED("rsion")] 
		public CUInt16 Rsion
		{
			get
			{
				if (_rsion == null)
				{
					_rsion = (CUInt16) CR2WTypeManager.Create("Uint16", "rsion", cr2w, this);
				}
				return _rsion;
			}
			set
			{
				if (_rsion == value)
				{
					return;
				}
				_rsion = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("pe")] 
		public CUInt16 Pe
		{
			get
			{
				if (_pe == null)
				{
					_pe = (CUInt16) CR2WTypeManager.Create("Uint16", "pe", cr2w, this);
				}
				return _pe;
			}
			set
			{
				if (_pe == value)
				{
					return;
				}
				_pe = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("mPositions")] 
		public CUInt16 MPositions
		{
			get
			{
				if (_mPositions == null)
				{
					_mPositions = (CUInt16) CR2WTypeManager.Create("Uint16", "mPositions", cr2w, this);
				}
				return _mPositions;
			}
			set
			{
				if (_mPositions == value)
				{
					return;
				}
				_mPositions = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("mRotations")] 
		public CUInt16 MRotations
		{
			get
			{
				if (_mRotations == null)
				{
					_mRotations = (CUInt16) CR2WTypeManager.Create("Uint16", "mRotations", cr2w, this);
				}
				return _mRotations;
			}
			set
			{
				if (_mRotations == value)
				{
					return;
				}
				_mRotations = value;
				PropertySet(this);
			}
		}

		public animAnimFallbackFrameDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
