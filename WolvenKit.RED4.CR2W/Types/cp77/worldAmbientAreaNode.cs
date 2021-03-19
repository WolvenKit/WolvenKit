using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAmbientAreaNode : worldTriggerAreaNode
	{
		private CBool _useCustomColor;

		[Ordinal(7)] 
		[RED("useCustomColor")] 
		public CBool UseCustomColor
		{
			get => GetProperty(ref _useCustomColor);
			set => SetProperty(ref _useCustomColor, value);
		}

		public worldAmbientAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
