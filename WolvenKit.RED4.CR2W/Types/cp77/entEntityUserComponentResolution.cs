using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entEntityUserComponentResolution : CVariable
	{
		private CRUID _id;
		private raRef<entEntityTemplate> _include;
		private CEnum<entEntityUserComponentResolutionMode> _mode;

		[Ordinal(0)] 
		[RED("id")] 
		public CRUID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("include")] 
		public raRef<entEntityTemplate> Include
		{
			get => GetProperty(ref _include);
			set => SetProperty(ref _include, value);
		}

		[Ordinal(2)] 
		[RED("mode")] 
		public CEnum<entEntityUserComponentResolutionMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		public entEntityUserComponentResolution(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
