using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimGraphResourceContainerEntry : CVariable
	{
		private CName _graphName;
		private rRef<animAnimGraph> _animGraphResource;

		[Ordinal(0)] 
		[RED("graphName")] 
		public CName GraphName
		{
			get => GetProperty(ref _graphName);
			set => SetProperty(ref _graphName, value);
		}

		[Ordinal(1)] 
		[RED("animGraphResource")] 
		public rRef<animAnimGraph> AnimGraphResource
		{
			get => GetProperty(ref _animGraphResource);
			set => SetProperty(ref _animGraphResource, value);
		}

		public entAnimGraphResourceContainerEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
