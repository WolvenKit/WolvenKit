using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePlayerClimbInfo : IScriptable
	{
		private CHandle<worldgeometryDescriptionResult> _descResult;
		private Vector4 _obstacleEnd;
		private CBool _climbValid;
		private CBool _vaultValid;

		[Ordinal(0)] 
		[RED("descResult")] 
		public CHandle<worldgeometryDescriptionResult> DescResult
		{
			get
			{
				if (_descResult == null)
				{
					_descResult = (CHandle<worldgeometryDescriptionResult>) CR2WTypeManager.Create("handle:worldgeometryDescriptionResult", "descResult", cr2w, this);
				}
				return _descResult;
			}
			set
			{
				if (_descResult == value)
				{
					return;
				}
				_descResult = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("obstacleEnd")] 
		public Vector4 ObstacleEnd
		{
			get
			{
				if (_obstacleEnd == null)
				{
					_obstacleEnd = (Vector4) CR2WTypeManager.Create("Vector4", "obstacleEnd", cr2w, this);
				}
				return _obstacleEnd;
			}
			set
			{
				if (_obstacleEnd == value)
				{
					return;
				}
				_obstacleEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("climbValid")] 
		public CBool ClimbValid
		{
			get
			{
				if (_climbValid == null)
				{
					_climbValid = (CBool) CR2WTypeManager.Create("Bool", "climbValid", cr2w, this);
				}
				return _climbValid;
			}
			set
			{
				if (_climbValid == value)
				{
					return;
				}
				_climbValid = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("vaultValid")] 
		public CBool VaultValid
		{
			get
			{
				if (_vaultValid == null)
				{
					_vaultValid = (CBool) CR2WTypeManager.Create("Bool", "vaultValid", cr2w, this);
				}
				return _vaultValid;
			}
			set
			{
				if (_vaultValid == value)
				{
					return;
				}
				_vaultValid = value;
				PropertySet(this);
			}
		}

		public gamePlayerClimbInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
