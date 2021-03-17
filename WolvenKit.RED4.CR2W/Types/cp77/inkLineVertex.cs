using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLineVertex : CVariable
	{
		private Vector2 _int;
		private CEnum<inkLineType> _neType;

		[Ordinal(0)] 
		[RED("int")] 
		public Vector2 Int
		{
			get => GetProperty(ref _int);
			set => SetProperty(ref _int, value);
		}

		[Ordinal(1)] 
		[RED("neType")] 
		public CEnum<inkLineType> NeType
		{
			get => GetProperty(ref _neType);
			set => SetProperty(ref _neType, value);
		}

		public inkLineVertex(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
