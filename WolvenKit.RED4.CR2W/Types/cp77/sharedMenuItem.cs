using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sharedMenuItem : CVariable
	{
		private CName _id;
		private CString _displayName;
		private CString _tooltip;
		private CArray<sharedMenuItem> _subItems;
		private CBool _isEnabled;
		private CEnum<sharedMenuItemType> _type;
		private CBool _isChecked;
		private CString _checkGroup;

		[Ordinal(0)] 
		[RED("id")] 
		public CName Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("displayName")] 
		public CString DisplayName
		{
			get => GetProperty(ref _displayName);
			set => SetProperty(ref _displayName, value);
		}

		[Ordinal(2)] 
		[RED("tooltip")] 
		public CString Tooltip
		{
			get => GetProperty(ref _tooltip);
			set => SetProperty(ref _tooltip, value);
		}

		[Ordinal(3)] 
		[RED("subItems")] 
		public CArray<sharedMenuItem> SubItems
		{
			get => GetProperty(ref _subItems);
			set => SetProperty(ref _subItems, value);
		}

		[Ordinal(4)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<sharedMenuItemType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(6)] 
		[RED("isChecked")] 
		public CBool IsChecked
		{
			get => GetProperty(ref _isChecked);
			set => SetProperty(ref _isChecked, value);
		}

		[Ordinal(7)] 
		[RED("checkGroup")] 
		public CString CheckGroup
		{
			get => GetProperty(ref _checkGroup);
			set => SetProperty(ref _checkGroup, value);
		}

		public sharedMenuItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
