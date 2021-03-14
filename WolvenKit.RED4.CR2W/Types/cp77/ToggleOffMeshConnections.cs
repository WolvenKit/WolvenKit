using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleOffMeshConnections : redEvent
	{
		private CBool _enable;
		private CBool _affectsPlayer;
		private CBool _affectsNPCs;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get
			{
				if (_enable == null)
				{
					_enable = (CBool) CR2WTypeManager.Create("Bool", "enable", cr2w, this);
				}
				return _enable;
			}
			set
			{
				if (_enable == value)
				{
					return;
				}
				_enable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("affectsPlayer")] 
		public CBool AffectsPlayer
		{
			get
			{
				if (_affectsPlayer == null)
				{
					_affectsPlayer = (CBool) CR2WTypeManager.Create("Bool", "affectsPlayer", cr2w, this);
				}
				return _affectsPlayer;
			}
			set
			{
				if (_affectsPlayer == value)
				{
					return;
				}
				_affectsPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("affectsNPCs")] 
		public CBool AffectsNPCs
		{
			get
			{
				if (_affectsNPCs == null)
				{
					_affectsNPCs = (CBool) CR2WTypeManager.Create("Bool", "affectsNPCs", cr2w, this);
				}
				return _affectsNPCs;
			}
			set
			{
				if (_affectsNPCs == value)
				{
					return;
				}
				_affectsNPCs = value;
				PropertySet(this);
			}
		}

		public ToggleOffMeshConnections(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
