using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Multilayer_LayerTemplateOverridesColor : CVariable
	{
		private CName _n;
		private CArrayFixedSize<CFloat> _v;

		[Ordinal(0)] 
		[RED("n")] 
		public CName N
		{
			get
			{
				if (_n == null)
				{
					_n = (CName) CR2WTypeManager.Create("CName", "n", cr2w, this);
				}
				return _n;
			}
			set
			{
				if (_n == value)
				{
					return;
				}
				_n = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("v", 3)] 
		public CArrayFixedSize<CFloat> V
		{
			get
			{
				if (_v == null)
				{
					_v = (CArrayFixedSize<CFloat>) CR2WTypeManager.Create("[3]Float", "v", cr2w, this);
				}
				return _v;
			}
			set
			{
				if (_v == value)
				{
					return;
				}
				_v = value;
				PropertySet(this);
			}
		}

		public Multilayer_LayerTemplateOverridesColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
