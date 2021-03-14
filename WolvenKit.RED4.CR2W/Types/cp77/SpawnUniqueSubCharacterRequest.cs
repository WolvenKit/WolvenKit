using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpawnUniqueSubCharacterRequest : gameScriptableSystemRequest
	{
		private TweakDBID _subCharacterID;
		private CFloat _desiredDistance;

		[Ordinal(0)] 
		[RED("subCharacterID")] 
		public TweakDBID SubCharacterID
		{
			get
			{
				if (_subCharacterID == null)
				{
					_subCharacterID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "subCharacterID", cr2w, this);
				}
				return _subCharacterID;
			}
			set
			{
				if (_subCharacterID == value)
				{
					return;
				}
				_subCharacterID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("desiredDistance")] 
		public CFloat DesiredDistance
		{
			get
			{
				if (_desiredDistance == null)
				{
					_desiredDistance = (CFloat) CR2WTypeManager.Create("Float", "desiredDistance", cr2w, this);
				}
				return _desiredDistance;
			}
			set
			{
				if (_desiredDistance == value)
				{
					return;
				}
				_desiredDistance = value;
				PropertySet(this);
			}
		}

		public SpawnUniqueSubCharacterRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
