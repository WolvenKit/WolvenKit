using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtPreset_FullControl : animLookAtPreset
	{
		private animLookAtLimits _limits;
		private CFloat _eyesSuppress;
		private CInt32 _eyesMode;
		private CFloat _headSuppress;
		private CInt32 _headMode;
		private CFloat _headSquareScale;
		private CFloat _chestSuppress;
		private CInt32 _chestMode;
		private CFloat _chestSquareScale;

		[Ordinal(0)] 
		[RED("limits")] 
		public animLookAtLimits Limits
		{
			get
			{
				if (_limits == null)
				{
					_limits = (animLookAtLimits) CR2WTypeManager.Create("animLookAtLimits", "limits", cr2w, this);
				}
				return _limits;
			}
			set
			{
				if (_limits == value)
				{
					return;
				}
				_limits = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("eyesSuppress")] 
		public CFloat EyesSuppress
		{
			get
			{
				if (_eyesSuppress == null)
				{
					_eyesSuppress = (CFloat) CR2WTypeManager.Create("Float", "eyesSuppress", cr2w, this);
				}
				return _eyesSuppress;
			}
			set
			{
				if (_eyesSuppress == value)
				{
					return;
				}
				_eyesSuppress = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("eyesMode")] 
		public CInt32 EyesMode
		{
			get
			{
				if (_eyesMode == null)
				{
					_eyesMode = (CInt32) CR2WTypeManager.Create("Int32", "eyesMode", cr2w, this);
				}
				return _eyesMode;
			}
			set
			{
				if (_eyesMode == value)
				{
					return;
				}
				_eyesMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("headSuppress")] 
		public CFloat HeadSuppress
		{
			get
			{
				if (_headSuppress == null)
				{
					_headSuppress = (CFloat) CR2WTypeManager.Create("Float", "headSuppress", cr2w, this);
				}
				return _headSuppress;
			}
			set
			{
				if (_headSuppress == value)
				{
					return;
				}
				_headSuppress = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("headMode")] 
		public CInt32 HeadMode
		{
			get
			{
				if (_headMode == null)
				{
					_headMode = (CInt32) CR2WTypeManager.Create("Int32", "headMode", cr2w, this);
				}
				return _headMode;
			}
			set
			{
				if (_headMode == value)
				{
					return;
				}
				_headMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("headSquareScale")] 
		public CFloat HeadSquareScale
		{
			get
			{
				if (_headSquareScale == null)
				{
					_headSquareScale = (CFloat) CR2WTypeManager.Create("Float", "headSquareScale", cr2w, this);
				}
				return _headSquareScale;
			}
			set
			{
				if (_headSquareScale == value)
				{
					return;
				}
				_headSquareScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("chestSuppress")] 
		public CFloat ChestSuppress
		{
			get
			{
				if (_chestSuppress == null)
				{
					_chestSuppress = (CFloat) CR2WTypeManager.Create("Float", "chestSuppress", cr2w, this);
				}
				return _chestSuppress;
			}
			set
			{
				if (_chestSuppress == value)
				{
					return;
				}
				_chestSuppress = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("chestMode")] 
		public CInt32 ChestMode
		{
			get
			{
				if (_chestMode == null)
				{
					_chestMode = (CInt32) CR2WTypeManager.Create("Int32", "chestMode", cr2w, this);
				}
				return _chestMode;
			}
			set
			{
				if (_chestMode == value)
				{
					return;
				}
				_chestMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("chestSquareScale")] 
		public CFloat ChestSquareScale
		{
			get
			{
				if (_chestSquareScale == null)
				{
					_chestSquareScale = (CFloat) CR2WTypeManager.Create("Float", "chestSquareScale", cr2w, this);
				}
				return _chestSquareScale;
			}
			set
			{
				if (_chestSquareScale == value)
				{
					return;
				}
				_chestSquareScale = value;
				PropertySet(this);
			}
		}

		public animLookAtPreset_FullControl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
