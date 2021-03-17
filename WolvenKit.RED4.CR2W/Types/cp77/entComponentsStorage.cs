using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entComponentsStorage : ISerializable
	{
		private CArray<CHandle<entIComponent>> _components;

		[Ordinal(0)] 
		[RED("components")] 
		public CArray<CHandle<entIComponent>> Components
		{
			get => GetProperty(ref _components);
			set => SetProperty(ref _components, value);
		}

		public entComponentsStorage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
