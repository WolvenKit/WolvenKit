using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SlotMachineSlot : inkWidgetLogicController
	{
		private CInt32 _winningRowIndex;
		private CArray<inkImageWidgetReference> _imagesUpper;
		private CArray<inkImageWidgetReference> _imagesLower;
		private CArray<CName> _imagePresets;

		[Ordinal(1)] 
		[RED("winningRowIndex")] 
		public CInt32 WinningRowIndex
		{
			get
			{
				if (_winningRowIndex == null)
				{
					_winningRowIndex = (CInt32) CR2WTypeManager.Create("Int32", "winningRowIndex", cr2w, this);
				}
				return _winningRowIndex;
			}
			set
			{
				if (_winningRowIndex == value)
				{
					return;
				}
				_winningRowIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("imagesUpper")] 
		public CArray<inkImageWidgetReference> ImagesUpper
		{
			get
			{
				if (_imagesUpper == null)
				{
					_imagesUpper = (CArray<inkImageWidgetReference>) CR2WTypeManager.Create("array:inkImageWidgetReference", "imagesUpper", cr2w, this);
				}
				return _imagesUpper;
			}
			set
			{
				if (_imagesUpper == value)
				{
					return;
				}
				_imagesUpper = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("imagesLower")] 
		public CArray<inkImageWidgetReference> ImagesLower
		{
			get
			{
				if (_imagesLower == null)
				{
					_imagesLower = (CArray<inkImageWidgetReference>) CR2WTypeManager.Create("array:inkImageWidgetReference", "imagesLower", cr2w, this);
				}
				return _imagesLower;
			}
			set
			{
				if (_imagesLower == value)
				{
					return;
				}
				_imagesLower = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("imagePresets")] 
		public CArray<CName> ImagePresets
		{
			get
			{
				if (_imagePresets == null)
				{
					_imagePresets = (CArray<CName>) CR2WTypeManager.Create("array:CName", "imagePresets", cr2w, this);
				}
				return _imagePresets;
			}
			set
			{
				if (_imagePresets == value)
				{
					return;
				}
				_imagePresets = value;
				PropertySet(this);
			}
		}

		public SlotMachineSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
