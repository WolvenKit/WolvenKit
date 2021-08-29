using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestListHeaderData : IScriptable
	{
		private CInt32 _type;
		private CName _nameLocKey;

		[Ordinal(0)] 
		[RED("type")] 
		public CInt32 Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("nameLocKey")] 
		public CName NameLocKey
		{
			get => GetProperty(ref _nameLocKey);
			set => SetProperty(ref _nameLocKey, value);
		}
	}
}
