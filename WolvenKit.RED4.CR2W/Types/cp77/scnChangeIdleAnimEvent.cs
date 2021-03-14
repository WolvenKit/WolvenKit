using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChangeIdleAnimEvent : scnPlayAnimEvent
	{
		private CName _idleAnimName;
		private CName _addIdleAnimName;
		private CBool _isEnabled;
		private CName _animName;
		private animFacialEmotionTransitionBaked _bakedFacialTransition;
		private CBool _facialInstantTransition;

		[Ordinal(15)] 
		[RED("idleAnimName")] 
		public CName IdleAnimName
		{
			get
			{
				if (_idleAnimName == null)
				{
					_idleAnimName = (CName) CR2WTypeManager.Create("CName", "idleAnimName", cr2w, this);
				}
				return _idleAnimName;
			}
			set
			{
				if (_idleAnimName == value)
				{
					return;
				}
				_idleAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("addIdleAnimName")] 
		public CName AddIdleAnimName
		{
			get
			{
				if (_addIdleAnimName == null)
				{
					_addIdleAnimName = (CName) CR2WTypeManager.Create("CName", "addIdleAnimName", cr2w, this);
				}
				return _addIdleAnimName;
			}
			set
			{
				if (_addIdleAnimName == value)
				{
					return;
				}
				_addIdleAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("animName")] 
		public CName AnimName
		{
			get
			{
				if (_animName == null)
				{
					_animName = (CName) CR2WTypeManager.Create("CName", "animName", cr2w, this);
				}
				return _animName;
			}
			set
			{
				if (_animName == value)
				{
					return;
				}
				_animName = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("bakedFacialTransition")] 
		public animFacialEmotionTransitionBaked BakedFacialTransition
		{
			get
			{
				if (_bakedFacialTransition == null)
				{
					_bakedFacialTransition = (animFacialEmotionTransitionBaked) CR2WTypeManager.Create("animFacialEmotionTransitionBaked", "bakedFacialTransition", cr2w, this);
				}
				return _bakedFacialTransition;
			}
			set
			{
				if (_bakedFacialTransition == value)
				{
					return;
				}
				_bakedFacialTransition = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("facialInstantTransition")] 
		public CBool FacialInstantTransition
		{
			get
			{
				if (_facialInstantTransition == null)
				{
					_facialInstantTransition = (CBool) CR2WTypeManager.Create("Bool", "facialInstantTransition", cr2w, this);
				}
				return _facialInstantTransition;
			}
			set
			{
				if (_facialInstantTransition == value)
				{
					return;
				}
				_facialInstantTransition = value;
				PropertySet(this);
			}
		}

		public scnChangeIdleAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
