using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForkliftSetup : CVariable
	{
		private CName _actionActivateName;
		private CFloat _liftingAnimationTime;
		private CBool _hasDistractionQuickhack;

		[Ordinal(0)] 
		[RED("actionActivateName")] 
		public CName ActionActivateName
		{
			get
			{
				if (_actionActivateName == null)
				{
					_actionActivateName = (CName) CR2WTypeManager.Create("CName", "actionActivateName", cr2w, this);
				}
				return _actionActivateName;
			}
			set
			{
				if (_actionActivateName == value)
				{
					return;
				}
				_actionActivateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("liftingAnimationTime")] 
		public CFloat LiftingAnimationTime
		{
			get
			{
				if (_liftingAnimationTime == null)
				{
					_liftingAnimationTime = (CFloat) CR2WTypeManager.Create("Float", "liftingAnimationTime", cr2w, this);
				}
				return _liftingAnimationTime;
			}
			set
			{
				if (_liftingAnimationTime == value)
				{
					return;
				}
				_liftingAnimationTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hasDistractionQuickhack")] 
		public CBool HasDistractionQuickhack
		{
			get
			{
				if (_hasDistractionQuickhack == null)
				{
					_hasDistractionQuickhack = (CBool) CR2WTypeManager.Create("Bool", "hasDistractionQuickhack", cr2w, this);
				}
				return _hasDistractionQuickhack;
			}
			set
			{
				if (_hasDistractionQuickhack == value)
				{
					return;
				}
				_hasDistractionQuickhack = value;
				PropertySet(this);
			}
		}

		public ForkliftSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
