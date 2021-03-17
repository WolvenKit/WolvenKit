using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questForceVMModule_NodeTypeParams : CVariable
	{
		private gameEntityReference _reference;
		private CString _module;
		private CArray<CName> _components;

		[Ordinal(0)] 
		[RED("reference")] 
		public gameEntityReference Reference
		{
			get => GetProperty(ref _reference);
			set => SetProperty(ref _reference, value);
		}

		[Ordinal(1)] 
		[RED("module")] 
		public CString Module
		{
			get => GetProperty(ref _module);
			set => SetProperty(ref _module, value);
		}

		[Ordinal(2)] 
		[RED("components")] 
		public CArray<CName> Components
		{
			get => GetProperty(ref _components);
			set => SetProperty(ref _components, value);
		}

		public questForceVMModule_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
