using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkPropertyManager : ISerializable
	{
		private CArray<inkPropertyBinding> _bindings;

		[Ordinal(0)] 
		[RED("bindings")] 
		public CArray<inkPropertyBinding> Bindings
		{
			get => GetProperty(ref _bindings);
			set => SetProperty(ref _bindings, value);
		}

		public inkPropertyManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
