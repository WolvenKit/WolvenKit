using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitRepresentationResult : CVariable
	{
		private gameQueryResult _sult;
		private entEntityID _tityID;

		[Ordinal(0)] 
		[RED("sult")] 
		public gameQueryResult Sult
		{
			get
			{
				if (_sult == null)
				{
					_sult = (gameQueryResult) CR2WTypeManager.Create("gameQueryResult", "sult", cr2w, this);
				}
				return _sult;
			}
			set
			{
				if (_sult == value)
				{
					return;
				}
				_sult = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("tityID")] 
		public entEntityID TityID
		{
			get
			{
				if (_tityID == null)
				{
					_tityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "tityID", cr2w, this);
				}
				return _tityID;
			}
			set
			{
				if (_tityID == value)
				{
					return;
				}
				_tityID = value;
				PropertySet(this);
			}
		}

		public gameHitRepresentationResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
