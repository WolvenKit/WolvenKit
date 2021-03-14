using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtAdditionalPreset_FullControl : animLookAtAdditionalPreset
	{
		private CBool _useRightHand;
		private CBool _attachHandToOtherOne;
		private animLookAtLimits _limits;
		private CFloat _suppress;
		private CInt32 _mode;

		[Ordinal(0)] 
		[RED("useRightHand")] 
		public CBool UseRightHand
		{
			get
			{
				if (_useRightHand == null)
				{
					_useRightHand = (CBool) CR2WTypeManager.Create("Bool", "useRightHand", cr2w, this);
				}
				return _useRightHand;
			}
			set
			{
				if (_useRightHand == value)
				{
					return;
				}
				_useRightHand = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("attachHandToOtherOne")] 
		public CBool AttachHandToOtherOne
		{
			get
			{
				if (_attachHandToOtherOne == null)
				{
					_attachHandToOtherOne = (CBool) CR2WTypeManager.Create("Bool", "attachHandToOtherOne", cr2w, this);
				}
				return _attachHandToOtherOne;
			}
			set
			{
				if (_attachHandToOtherOne == value)
				{
					return;
				}
				_attachHandToOtherOne = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("suppress")] 
		public CFloat Suppress
		{
			get
			{
				if (_suppress == null)
				{
					_suppress = (CFloat) CR2WTypeManager.Create("Float", "suppress", cr2w, this);
				}
				return _suppress;
			}
			set
			{
				if (_suppress == value)
				{
					return;
				}
				_suppress = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("mode")] 
		public CInt32 Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CInt32) CR2WTypeManager.Create("Int32", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		public animLookAtAdditionalPreset_FullControl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
