using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTemplateBindingOverride : CVariable
	{
		private CName _componentName;
		private CName _propertyName;
		private CHandle<entIBinding> _binding;

		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get
			{
				if (_componentName == null)
				{
					_componentName = (CName) CR2WTypeManager.Create("CName", "componentName", cr2w, this);
				}
				return _componentName;
			}
			set
			{
				if (_componentName == value)
				{
					return;
				}
				_componentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("propertyName")] 
		public CName PropertyName
		{
			get
			{
				if (_propertyName == null)
				{
					_propertyName = (CName) CR2WTypeManager.Create("CName", "propertyName", cr2w, this);
				}
				return _propertyName;
			}
			set
			{
				if (_propertyName == value)
				{
					return;
				}
				_propertyName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("binding")] 
		public CHandle<entIBinding> Binding
		{
			get
			{
				if (_binding == null)
				{
					_binding = (CHandle<entIBinding>) CR2WTypeManager.Create("handle:entIBinding", "binding", cr2w, this);
				}
				return _binding;
			}
			set
			{
				if (_binding == value)
				{
					return;
				}
				_binding = value;
				PropertySet(this);
			}
		}

		public entTemplateBindingOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
