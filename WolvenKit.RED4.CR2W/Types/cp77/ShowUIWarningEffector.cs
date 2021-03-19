using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShowUIWarningEffector : gameEffector
	{
		private CFloat _duration;
		private CString _primaryText;
		private CString _secondaryText;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(1)] 
		[RED("primaryText")] 
		public CString PrimaryText
		{
			get => GetProperty(ref _primaryText);
			set => SetProperty(ref _primaryText, value);
		}

		[Ordinal(2)] 
		[RED("secondaryText")] 
		public CString SecondaryText
		{
			get => GetProperty(ref _secondaryText);
			set => SetProperty(ref _secondaryText, value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public ShowUIWarningEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
