using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtPartInfo_ : CVariable
	{
		private CName _partName;
		private CName _defaultPositionBoneName;

		[Ordinal(0)] 
		[RED("partName")] 
		public CName PartName
		{
			get
			{
				if (_partName == null)
				{
					_partName = (CName) CR2WTypeManager.Create("CName", "partName", cr2w, this);
				}
				return _partName;
			}
			set
			{
				if (_partName == value)
				{
					return;
				}
				_partName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("defaultPositionBoneName")] 
		public CName DefaultPositionBoneName
		{
			get
			{
				if (_defaultPositionBoneName == null)
				{
					_defaultPositionBoneName = (CName) CR2WTypeManager.Create("CName", "defaultPositionBoneName", cr2w, this);
				}
				return _defaultPositionBoneName;
			}
			set
			{
				if (_defaultPositionBoneName == value)
				{
					return;
				}
				_defaultPositionBoneName = value;
				PropertySet(this);
			}
		}

		public animLookAtPartInfo_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
