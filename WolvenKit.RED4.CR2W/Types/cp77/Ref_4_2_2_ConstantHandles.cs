using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_4_2_2_ConstantHandles : IScriptable
	{
		private CInt32 _i;
		private CFloat _f;
		private CHandle<IScriptable> _s;

		[Ordinal(0)] 
		[RED("i")] 
		public CInt32 I
		{
			get
			{
				if (_i == null)
				{
					_i = (CInt32) CR2WTypeManager.Create("Int32", "i", cr2w, this);
				}
				return _i;
			}
			set
			{
				if (_i == value)
				{
					return;
				}
				_i = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("f")] 
		public CFloat F
		{
			get
			{
				if (_f == null)
				{
					_f = (CFloat) CR2WTypeManager.Create("Float", "f", cr2w, this);
				}
				return _f;
			}
			set
			{
				if (_f == value)
				{
					return;
				}
				_f = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("s")] 
		public CHandle<IScriptable> S
		{
			get
			{
				if (_s == null)
				{
					_s = (CHandle<IScriptable>) CR2WTypeManager.Create("handle:IScriptable", "s", cr2w, this);
				}
				return _s;
			}
			set
			{
				if (_s == value)
				{
					return;
				}
				_s = value;
				PropertySet(this);
			}
		}

		public Ref_4_2_2_ConstantHandles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
