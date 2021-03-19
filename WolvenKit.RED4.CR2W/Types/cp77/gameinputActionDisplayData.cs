using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinputActionDisplayData : CVariable
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

		public gameinputActionDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
