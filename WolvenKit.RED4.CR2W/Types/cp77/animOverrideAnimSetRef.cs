using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animOverrideAnimSetRef : CVariable
	{
		private raRef<animAnimSet> _animSet;
		private CName _variableName;

		[Ordinal(0)] 
		[RED("animSet")] 
		public raRef<animAnimSet> AnimSet
		{
			get => GetProperty(ref _animSet);
			set => SetProperty(ref _animSet, value);
		}

		[Ordinal(1)] 
		[RED("variableName")] 
		public CName VariableName
		{
			get => GetProperty(ref _variableName);
			set => SetProperty(ref _variableName, value);
		}

		public animOverrideAnimSetRef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
