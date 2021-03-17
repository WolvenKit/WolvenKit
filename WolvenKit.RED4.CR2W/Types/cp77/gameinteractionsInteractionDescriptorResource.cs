using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsInteractionDescriptorResource : CResource
	{
		private gameinteractionsCHotSpotDefinition _definition;

		[Ordinal(1)] 
		[RED("definition")] 
		public gameinteractionsCHotSpotDefinition Definition
		{
			get => GetProperty(ref _definition);
			set => SetProperty(ref _definition, value);
		}

		public gameinteractionsInteractionDescriptorResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
