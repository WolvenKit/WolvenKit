using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_1_4_2_HandlesOwner : CVariable
	{
		private CHandle<Ref_1_4_2_Class> _obj;
		private wCHandle<Ref_1_4_2_Class> _weakObj;

		[Ordinal(0)] 
		[RED("obj")] 
		public CHandle<Ref_1_4_2_Class> Obj
		{
			get => GetProperty(ref _obj);
			set => SetProperty(ref _obj, value);
		}

		[Ordinal(1)] 
		[RED("weakObj")] 
		public wCHandle<Ref_1_4_2_Class> WeakObj
		{
			get => GetProperty(ref _weakObj);
			set => SetProperty(ref _weakObj, value);
		}

		public Ref_1_4_2_HandlesOwner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
