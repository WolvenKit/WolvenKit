using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDynamicEventsPerVisualTags : CVariable
	{
		private CArray<CName> _visualTags;
		private CArray<audioDynamicEventsWithInterval> _grunts;

		[Ordinal(0)] 
		[RED("visualTags")] 
		public CArray<CName> VisualTags
		{
			get => GetProperty(ref _visualTags);
			set => SetProperty(ref _visualTags, value);
		}

		[Ordinal(1)] 
		[RED("grunts")] 
		public CArray<audioDynamicEventsWithInterval> Grunts
		{
			get => GetProperty(ref _grunts);
			set => SetProperty(ref _grunts, value);
		}

		public audioDynamicEventsPerVisualTags(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
