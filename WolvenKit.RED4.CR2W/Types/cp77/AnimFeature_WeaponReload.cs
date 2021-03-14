using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponReload : animAnimFeature
	{
		private CBool _emptyReload;
		private CInt32 _amountToReload;
		private CBool _continueLoop;
		private CFloat _loopDuration;
		private CFloat _emptyDuration;

		[Ordinal(0)] 
		[RED("emptyReload")] 
		public CBool EmptyReload
		{
			get
			{
				if (_emptyReload == null)
				{
					_emptyReload = (CBool) CR2WTypeManager.Create("Bool", "emptyReload", cr2w, this);
				}
				return _emptyReload;
			}
			set
			{
				if (_emptyReload == value)
				{
					return;
				}
				_emptyReload = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("amountToReload")] 
		public CInt32 AmountToReload
		{
			get
			{
				if (_amountToReload == null)
				{
					_amountToReload = (CInt32) CR2WTypeManager.Create("Int32", "amountToReload", cr2w, this);
				}
				return _amountToReload;
			}
			set
			{
				if (_amountToReload == value)
				{
					return;
				}
				_amountToReload = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("continueLoop")] 
		public CBool ContinueLoop
		{
			get
			{
				if (_continueLoop == null)
				{
					_continueLoop = (CBool) CR2WTypeManager.Create("Bool", "continueLoop", cr2w, this);
				}
				return _continueLoop;
			}
			set
			{
				if (_continueLoop == value)
				{
					return;
				}
				_continueLoop = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("loopDuration")] 
		public CFloat LoopDuration
		{
			get
			{
				if (_loopDuration == null)
				{
					_loopDuration = (CFloat) CR2WTypeManager.Create("Float", "loopDuration", cr2w, this);
				}
				return _loopDuration;
			}
			set
			{
				if (_loopDuration == value)
				{
					return;
				}
				_loopDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("emptyDuration")] 
		public CFloat EmptyDuration
		{
			get
			{
				if (_emptyDuration == null)
				{
					_emptyDuration = (CFloat) CR2WTypeManager.Create("Float", "emptyDuration", cr2w, this);
				}
				return _emptyDuration;
			}
			set
			{
				if (_emptyDuration == value)
				{
					return;
				}
				_emptyDuration = value;
				PropertySet(this);
			}
		}

		public AnimFeature_WeaponReload(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
