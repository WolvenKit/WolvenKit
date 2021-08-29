using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinputActionDisplayData : RedBaseClass
	{
		private CName _name;
		private CBool _isHold;
		private CString _inputDisplayPad;
		private CString _inputDisplayKeyboard;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("isHold")] 
		public CBool IsHold
		{
			get => GetProperty(ref _isHold);
			set => SetProperty(ref _isHold, value);
		}

		[Ordinal(2)] 
		[RED("inputDisplayPad")] 
		public CString InputDisplayPad
		{
			get => GetProperty(ref _inputDisplayPad);
			set => SetProperty(ref _inputDisplayPad, value);
		}

		[Ordinal(3)] 
		[RED("inputDisplayKeyboard")] 
		public CString InputDisplayKeyboard
		{
			get => GetProperty(ref _inputDisplayKeyboard);
			set => SetProperty(ref _inputDisplayKeyboard, value);
		}
	}
}
