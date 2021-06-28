using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStreamingSectorInplaceContent : CResource
	{
		private CArray<rRef<CResource>> _inplaceResources;

		[Ordinal(1)] 
		[RED("inplaceResources")] 
		public CArray<rRef<CResource>> InplaceResources
		{
			get => GetProperty(ref _inplaceResources);
			set => SetProperty(ref _inplaceResources, value);
		}

		public worldStreamingSectorInplaceContent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
