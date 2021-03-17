using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GuardbreakReactionTask : AIHitReactionTask
	{
		private TweakDBID _tweakDBPackage;

		[Ordinal(4)] 
		[RED("tweakDBPackage")] 
		public TweakDBID TweakDBPackage
		{
			get => GetProperty(ref _tweakDBPackage);
			set => SetProperty(ref _tweakDBPackage, value);
		}

		public GuardbreakReactionTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
