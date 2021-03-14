using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectSettings : CVariable
	{
		private CBool _advancedTargetHandling;
		private CBool _synchronousProcessingForPlayer;
		private CBool _forceSynchronousProcessing;
		private CBool _tempExecuteOnlyOnce;

		[Ordinal(0)] 
		[RED("advancedTargetHandling")] 
		public CBool AdvancedTargetHandling
		{
			get
			{
				if (_advancedTargetHandling == null)
				{
					_advancedTargetHandling = (CBool) CR2WTypeManager.Create("Bool", "advancedTargetHandling", cr2w, this);
				}
				return _advancedTargetHandling;
			}
			set
			{
				if (_advancedTargetHandling == value)
				{
					return;
				}
				_advancedTargetHandling = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("synchronousProcessingForPlayer")] 
		public CBool SynchronousProcessingForPlayer
		{
			get
			{
				if (_synchronousProcessingForPlayer == null)
				{
					_synchronousProcessingForPlayer = (CBool) CR2WTypeManager.Create("Bool", "synchronousProcessingForPlayer", cr2w, this);
				}
				return _synchronousProcessingForPlayer;
			}
			set
			{
				if (_synchronousProcessingForPlayer == value)
				{
					return;
				}
				_synchronousProcessingForPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("forceSynchronousProcessing")] 
		public CBool ForceSynchronousProcessing
		{
			get
			{
				if (_forceSynchronousProcessing == null)
				{
					_forceSynchronousProcessing = (CBool) CR2WTypeManager.Create("Bool", "forceSynchronousProcessing", cr2w, this);
				}
				return _forceSynchronousProcessing;
			}
			set
			{
				if (_forceSynchronousProcessing == value)
				{
					return;
				}
				_forceSynchronousProcessing = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("tempExecuteOnlyOnce")] 
		public CBool TempExecuteOnlyOnce
		{
			get
			{
				if (_tempExecuteOnlyOnce == null)
				{
					_tempExecuteOnlyOnce = (CBool) CR2WTypeManager.Create("Bool", "tempExecuteOnlyOnce", cr2w, this);
				}
				return _tempExecuteOnlyOnce;
			}
			set
			{
				if (_tempExecuteOnlyOnce == value)
				{
					return;
				}
				_tempExecuteOnlyOnce = value;
				PropertySet(this);
			}
		}

		public gameEffectSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
