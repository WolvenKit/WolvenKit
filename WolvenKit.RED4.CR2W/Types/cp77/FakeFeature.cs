using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FakeFeature : gameObject
	{
		private CArray<SFakeFeatureChoice> _choices;
		private CHandle<gameinteractionsComponent> _interaction;
		private CArray<CHandle<entIPlacedComponent>> _components;
		private CHandle<gameScanningComponent> _scaningComponent;
		private CBool _was_used;

		[Ordinal(40)] 
		[RED("choices")] 
		public CArray<SFakeFeatureChoice> Choices
		{
			get
			{
				if (_choices == null)
				{
					_choices = (CArray<SFakeFeatureChoice>) CR2WTypeManager.Create("array:SFakeFeatureChoice", "choices", cr2w, this);
				}
				return _choices;
			}
			set
			{
				if (_choices == value)
				{
					return;
				}
				_choices = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get
			{
				if (_interaction == null)
				{
					_interaction = (CHandle<gameinteractionsComponent>) CR2WTypeManager.Create("handle:gameinteractionsComponent", "interaction", cr2w, this);
				}
				return _interaction;
			}
			set
			{
				if (_interaction == value)
				{
					return;
				}
				_interaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("components")] 
		public CArray<CHandle<entIPlacedComponent>> Components
		{
			get
			{
				if (_components == null)
				{
					_components = (CArray<CHandle<entIPlacedComponent>>) CR2WTypeManager.Create("array:handle:entIPlacedComponent", "components", cr2w, this);
				}
				return _components;
			}
			set
			{
				if (_components == value)
				{
					return;
				}
				_components = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("scaningComponent")] 
		public CHandle<gameScanningComponent> ScaningComponent
		{
			get
			{
				if (_scaningComponent == null)
				{
					_scaningComponent = (CHandle<gameScanningComponent>) CR2WTypeManager.Create("handle:gameScanningComponent", "scaningComponent", cr2w, this);
				}
				return _scaningComponent;
			}
			set
			{
				if (_scaningComponent == value)
				{
					return;
				}
				_scaningComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("was_used")] 
		public CBool Was_used
		{
			get
			{
				if (_was_used == null)
				{
					_was_used = (CBool) CR2WTypeManager.Create("Bool", "was_used", cr2w, this);
				}
				return _was_used;
			}
			set
			{
				if (_was_used == value)
				{
					return;
				}
				_was_used = value;
				PropertySet(this);
			}
		}

		public FakeFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
