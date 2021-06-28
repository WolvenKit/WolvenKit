using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkPropertyBinding : CVariable
	{
		private CName _propertyName;
		private CName _stylePath;

		[Ordinal(0)] 
		[RED("propertyName")] 
		public CName PropertyName
		{
			get => GetProperty(ref _propertyName);
			set => SetProperty(ref _propertyName, value);
		}

		[Ordinal(1)] 
		[RED("stylePath")] 
		public CName StylePath
		{
			get => GetProperty(ref _stylePath);
			set => SetProperty(ref _stylePath, value);
		}

		public inkPropertyBinding(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
