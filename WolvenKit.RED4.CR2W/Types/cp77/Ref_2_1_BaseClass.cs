using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_2_1_BaseClass : IScriptable
	{
		private CInt32 _prop1;
		private CInt32 _prop2;
		private CInt32 _prop3;

		[Ordinal(0)] 
		[RED("prop1")] 
		public CInt32 Prop1
		{
			get
			{
				if (_prop1 == null)
				{
					_prop1 = (CInt32) CR2WTypeManager.Create("Int32", "prop1", cr2w, this);
				}
				return _prop1;
			}
			set
			{
				if (_prop1 == value)
				{
					return;
				}
				_prop1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("prop2")] 
		public CInt32 Prop2
		{
			get
			{
				if (_prop2 == null)
				{
					_prop2 = (CInt32) CR2WTypeManager.Create("Int32", "prop2", cr2w, this);
				}
				return _prop2;
			}
			set
			{
				if (_prop2 == value)
				{
					return;
				}
				_prop2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("prop3")] 
		public CInt32 Prop3
		{
			get
			{
				if (_prop3 == null)
				{
					_prop3 = (CInt32) CR2WTypeManager.Create("Int32", "prop3", cr2w, this);
				}
				return _prop3;
			}
			set
			{
				if (_prop3 == value)
				{
					return;
				}
				_prop3 = value;
				PropertySet(this);
			}
		}

		public Ref_2_1_BaseClass(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
