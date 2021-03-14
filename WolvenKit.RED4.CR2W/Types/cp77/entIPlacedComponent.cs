using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entIPlacedComponent : entIComponent
	{
		private WorldTransform _localTransform;
		private CHandle<entITransformBinding> _parentTransform;

		[Ordinal(3)] 
		[RED("localTransform")] 
		public WorldTransform LocalTransform
		{
			get
			{
				if (_localTransform == null)
				{
					_localTransform = (WorldTransform) CR2WTypeManager.Create("WorldTransform", "localTransform", cr2w, this);
				}
				return _localTransform;
			}
			set
			{
				if (_localTransform == value)
				{
					return;
				}
				_localTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("parentTransform")] 
		public CHandle<entITransformBinding> ParentTransform
		{
			get
			{
				if (_parentTransform == null)
				{
					_parentTransform = (CHandle<entITransformBinding>) CR2WTypeManager.Create("handle:entITransformBinding", "parentTransform", cr2w, this);
				}
				return _parentTransform;
			}
			set
			{
				if (_parentTransform == value)
				{
					return;
				}
				_parentTransform = value;
				PropertySet(this);
			}
		}

		public entIPlacedComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
