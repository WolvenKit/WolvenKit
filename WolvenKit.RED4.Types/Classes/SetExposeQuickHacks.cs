using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetExposeQuickHacks : ActionBool
	{
		private CBool _isRemote;

		[Ordinal(25)] 
		[RED("isRemote")] 
		public CBool IsRemote
		{
			get => GetProperty(ref _isRemote);
			set => SetProperty(ref _isRemote, value);
		}

		public SetExposeQuickHacks()
		{
			_isRemote = true;
		}
	}
}
