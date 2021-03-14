using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entFacialCustomizationComponent : entIComponent
	{
		private CBool _debugIgnoreComponent;
		private raRef<animFacialCustomizationSet> _customizationSet;
		private CUInt32 _eyes;
		private CUInt32 _nose;
		private CUInt32 _mouth;
		private CUInt32 _jaw;
		private CUInt32 _ears;

		[Ordinal(3)] 
		[RED("debugIgnoreComponent")] 
		public CBool DebugIgnoreComponent
		{
			get
			{
				if (_debugIgnoreComponent == null)
				{
					_debugIgnoreComponent = (CBool) CR2WTypeManager.Create("Bool", "debugIgnoreComponent", cr2w, this);
				}
				return _debugIgnoreComponent;
			}
			set
			{
				if (_debugIgnoreComponent == value)
				{
					return;
				}
				_debugIgnoreComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("customizationSet")] 
		public raRef<animFacialCustomizationSet> CustomizationSet
		{
			get
			{
				if (_customizationSet == null)
				{
					_customizationSet = (raRef<animFacialCustomizationSet>) CR2WTypeManager.Create("raRef:animFacialCustomizationSet", "customizationSet", cr2w, this);
				}
				return _customizationSet;
			}
			set
			{
				if (_customizationSet == value)
				{
					return;
				}
				_customizationSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("eyes")] 
		public CUInt32 Eyes
		{
			get
			{
				if (_eyes == null)
				{
					_eyes = (CUInt32) CR2WTypeManager.Create("Uint32", "eyes", cr2w, this);
				}
				return _eyes;
			}
			set
			{
				if (_eyes == value)
				{
					return;
				}
				_eyes = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("nose")] 
		public CUInt32 Nose
		{
			get
			{
				if (_nose == null)
				{
					_nose = (CUInt32) CR2WTypeManager.Create("Uint32", "nose", cr2w, this);
				}
				return _nose;
			}
			set
			{
				if (_nose == value)
				{
					return;
				}
				_nose = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("mouth")] 
		public CUInt32 Mouth
		{
			get
			{
				if (_mouth == null)
				{
					_mouth = (CUInt32) CR2WTypeManager.Create("Uint32", "mouth", cr2w, this);
				}
				return _mouth;
			}
			set
			{
				if (_mouth == value)
				{
					return;
				}
				_mouth = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("jaw")] 
		public CUInt32 Jaw
		{
			get
			{
				if (_jaw == null)
				{
					_jaw = (CUInt32) CR2WTypeManager.Create("Uint32", "jaw", cr2w, this);
				}
				return _jaw;
			}
			set
			{
				if (_jaw == value)
				{
					return;
				}
				_jaw = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("ears")] 
		public CUInt32 Ears
		{
			get
			{
				if (_ears == null)
				{
					_ears = (CUInt32) CR2WTypeManager.Create("Uint32", "ears", cr2w, this);
				}
				return _ears;
			}
			set
			{
				if (_ears == value)
				{
					return;
				}
				_ears = value;
				PropertySet(this);
			}
		}

		public entFacialCustomizationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
