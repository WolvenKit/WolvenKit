using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimSequence : IScriptable
	{
		private CName _name;
		private CArray<CHandle<inkanimDefinition>> _definitions;
		private CArray<CHandle<inkanimSequenceTargetInfo>> _targets;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("definitions")] 
		public CArray<CHandle<inkanimDefinition>> Definitions
		{
			get => GetProperty(ref _definitions);
			set => SetProperty(ref _definitions, value);
		}

		[Ordinal(2)] 
		[RED("targets")] 
		public CArray<CHandle<inkanimSequenceTargetInfo>> Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		public inkanimSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
