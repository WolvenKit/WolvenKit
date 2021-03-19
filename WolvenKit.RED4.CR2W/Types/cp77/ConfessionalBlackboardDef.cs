using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConfessionalBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Bool _isConfessing;

		[Ordinal(7)] 
		[RED("IsConfessing")] 
		public gamebbScriptID_Bool IsConfessing
		{
			get => GetProperty(ref _isConfessing);
			set => SetProperty(ref _isConfessing, value);
		}

		public ConfessionalBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
