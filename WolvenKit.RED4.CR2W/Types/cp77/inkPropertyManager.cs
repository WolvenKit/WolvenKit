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
			get
			{
				if (_bindings == null)
				{
					_bindings = (CArray<inkPropertyBinding>) CR2WTypeManager.Create("array:inkPropertyBinding", "bindings", cr2w, this);
				}
				return _bindings;
			}
			set
			{
				if (_bindings == value)
				{
					return;
				}
				_bindings = value;
				PropertySet(this);
			}
		}

		public inkPropertyManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
