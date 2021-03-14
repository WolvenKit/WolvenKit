using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorComponent : gameScriptableComponent
	{
		private TweakDBID _vendorTweakID;
		private CArray<JunkItemRecord> _junkItemArray;
		private CName _brandProcessingSFX;
		private CName _itemFallSFX;

		[Ordinal(5)] 
		[RED("vendorTweakID")] 
		public TweakDBID VendorTweakID
		{
			get
			{
				if (_vendorTweakID == null)
				{
					_vendorTweakID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "vendorTweakID", cr2w, this);
				}
				return _vendorTweakID;
			}
			set
			{
				if (_vendorTweakID == value)
				{
					return;
				}
				_vendorTweakID = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("junkItemArray")] 
		public CArray<JunkItemRecord> JunkItemArray
		{
			get
			{
				if (_junkItemArray == null)
				{
					_junkItemArray = (CArray<JunkItemRecord>) CR2WTypeManager.Create("array:JunkItemRecord", "junkItemArray", cr2w, this);
				}
				return _junkItemArray;
			}
			set
			{
				if (_junkItemArray == value)
				{
					return;
				}
				_junkItemArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("brandProcessingSFX")] 
		public CName BrandProcessingSFX
		{
			get
			{
				if (_brandProcessingSFX == null)
				{
					_brandProcessingSFX = (CName) CR2WTypeManager.Create("CName", "brandProcessingSFX", cr2w, this);
				}
				return _brandProcessingSFX;
			}
			set
			{
				if (_brandProcessingSFX == value)
				{
					return;
				}
				_brandProcessingSFX = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("itemFallSFX")] 
		public CName ItemFallSFX
		{
			get
			{
				if (_itemFallSFX == null)
				{
					_itemFallSFX = (CName) CR2WTypeManager.Create("CName", "itemFallSFX", cr2w, this);
				}
				return _itemFallSFX;
			}
			set
			{
				if (_itemFallSFX == value)
				{
					return;
				}
				_itemFallSFX = value;
				PropertySet(this);
			}
		}

		public VendorComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
