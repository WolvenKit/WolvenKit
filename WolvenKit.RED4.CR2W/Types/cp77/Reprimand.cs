using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Reprimand : MorphData
	{
		private ReprimandData _reprimandData;

		[Ordinal(1)] 
		[RED("reprimandData")] 
		public ReprimandData ReprimandData
		{
			get => GetProperty(ref _reprimandData);
			set => SetProperty(ref _reprimandData, value);
		}

		public Reprimand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
