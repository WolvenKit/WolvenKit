using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetFastTravelBinksGroup_NodeType : questIUIManagerNodeType
	{
		private TweakDBID _selectedBinkDataGroup;

		[Ordinal(0)] 
		[RED("selectedBinkDataGroup")] 
		public TweakDBID SelectedBinkDataGroup
		{
			get
			{
				if (_selectedBinkDataGroup == null)
				{
					_selectedBinkDataGroup = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "selectedBinkDataGroup", cr2w, this);
				}
				return _selectedBinkDataGroup;
			}
			set
			{
				if (_selectedBinkDataGroup == value)
				{
					return;
				}
				_selectedBinkDataGroup = value;
				PropertySet(this);
			}
		}

		public questSetFastTravelBinksGroup_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
