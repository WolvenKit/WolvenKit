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
			get
			{
				if (_obj == null)
				{
					_obj = (CHandle<Ref_1_4_2_Class>) CR2WTypeManager.Create("handle:Ref_1_4_2_Class", "obj", cr2w, this);
				}
				return _obj;
			}
			set
			{
				if (_obj == value)
				{
					return;
				}
				_obj = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("weakObj")] 
		public wCHandle<Ref_1_4_2_Class> WeakObj
		{
			get
			{
				if (_weakObj == null)
				{
					_weakObj = (wCHandle<Ref_1_4_2_Class>) CR2WTypeManager.Create("whandle:Ref_1_4_2_Class", "weakObj", cr2w, this);
				}
				return _weakObj;
			}
			set
			{
				if (_weakObj == value)
				{
					return;
				}
				_weakObj = value;
				PropertySet(this);
			}
		}

		public Ref_1_4_2_HandlesOwner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
