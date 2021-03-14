using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCompiledEffectPlacementInfo : CVariable
	{
		private CUInt8 _placementTagIndex;
		private CUInt8 _relativePositionIndex;
		private CUInt8 _relativeRotationIndex;
		private CUInt8 _flags;

		[Ordinal(0)] 
		[RED("placementTagIndex")] 
		public CUInt8 PlacementTagIndex
		{
			get
			{
				if (_placementTagIndex == null)
				{
					_placementTagIndex = (CUInt8) CR2WTypeManager.Create("Uint8", "placementTagIndex", cr2w, this);
				}
				return _placementTagIndex;
			}
			set
			{
				if (_placementTagIndex == value)
				{
					return;
				}
				_placementTagIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("relativePositionIndex")] 
		public CUInt8 RelativePositionIndex
		{
			get
			{
				if (_relativePositionIndex == null)
				{
					_relativePositionIndex = (CUInt8) CR2WTypeManager.Create("Uint8", "relativePositionIndex", cr2w, this);
				}
				return _relativePositionIndex;
			}
			set
			{
				if (_relativePositionIndex == value)
				{
					return;
				}
				_relativePositionIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("relativeRotationIndex")] 
		public CUInt8 RelativeRotationIndex
		{
			get
			{
				if (_relativeRotationIndex == null)
				{
					_relativeRotationIndex = (CUInt8) CR2WTypeManager.Create("Uint8", "relativeRotationIndex", cr2w, this);
				}
				return _relativeRotationIndex;
			}
			set
			{
				if (_relativeRotationIndex == value)
				{
					return;
				}
				_relativeRotationIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("flags")] 
		public CUInt8 Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CUInt8) CR2WTypeManager.Create("Uint8", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
				PropertySet(this);
			}
		}

		public worldCompiledEffectPlacementInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
