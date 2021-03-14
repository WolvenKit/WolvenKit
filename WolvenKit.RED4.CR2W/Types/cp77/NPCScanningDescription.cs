using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCScanningDescription : ObjectScanningDescription
	{
		private TweakDBID _nPCGameplayDescription;
		private CArray<TweakDBID> _nPCCustomDescriptions;

		[Ordinal(0)] 
		[RED("NPCGameplayDescription")] 
		public TweakDBID NPCGameplayDescription
		{
			get
			{
				if (_nPCGameplayDescription == null)
				{
					_nPCGameplayDescription = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "NPCGameplayDescription", cr2w, this);
				}
				return _nPCGameplayDescription;
			}
			set
			{
				if (_nPCGameplayDescription == value)
				{
					return;
				}
				_nPCGameplayDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("NPCCustomDescriptions")] 
		public CArray<TweakDBID> NPCCustomDescriptions
		{
			get
			{
				if (_nPCCustomDescriptions == null)
				{
					_nPCCustomDescriptions = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "NPCCustomDescriptions", cr2w, this);
				}
				return _nPCCustomDescriptions;
			}
			set
			{
				if (_nPCCustomDescriptions == value)
				{
					return;
				}
				_nPCCustomDescriptions = value;
				PropertySet(this);
			}
		}

		public NPCScanningDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
