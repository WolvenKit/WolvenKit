using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeatureEntry_ : CVariable
	{
		private CName _name;
		private CName _className;
		private CBool _forceAllocate;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetProperty(ref _className);
			set => SetProperty(ref _className, value);
		}

		[Ordinal(2)] 
		[RED("forceAllocate")] 
		public CBool ForceAllocate
		{
			get => GetProperty(ref _forceAllocate);
			set => SetProperty(ref _forceAllocate, value);
		}

		public animAnimFeatureEntry_(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
