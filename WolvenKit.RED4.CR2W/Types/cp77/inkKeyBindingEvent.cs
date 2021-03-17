using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkKeyBindingEvent : redEvent
	{
		private CName _keyName;

		[Ordinal(0)] 
		[RED("keyName")] 
		public CName KeyName
		{
			get => GetProperty(ref _keyName);
			set => SetProperty(ref _keyName, value);
		}

		public inkKeyBindingEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
