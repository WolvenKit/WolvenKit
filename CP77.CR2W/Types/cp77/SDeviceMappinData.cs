using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SDeviceMappinData : CVariable
	{
		[Ordinal(0)]  [RED("active")] public CBool Active { get; set; }
		[Ordinal(1)]  [RED("caption")] public CString Caption { get; set; }
		[Ordinal(2)]  [RED("checkIfIsTarget")] public CBool CheckIfIsTarget { get; set; }
		[Ordinal(3)]  [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(4)]  [RED("gameplayRole")] public CEnum<EGameplayRole> GameplayRole { get; set; }
		[Ordinal(5)]  [RED("id")] public gameNewMappinID Id { get; set; }
		[Ordinal(6)]  [RED("mappinName")] public CName MappinName { get; set; }
		[Ordinal(7)]  [RED("mappinType")] public TweakDBID MappinType { get; set; }
		[Ordinal(8)]  [RED("mappinVariant")] public CEnum<gamedataMappinVariant> MappinVariant { get; set; }
		[Ordinal(9)]  [RED("offset")] public Vector4 Offset { get; set; }
		[Ordinal(10)]  [RED("permanent")] public CBool Permanent { get; set; }
		[Ordinal(11)]  [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(12)]  [RED("range")] public CFloat Range { get; set; }
		[Ordinal(13)]  [RED("visualStateData")] public CHandle<GameplayRoleMappinData> VisualStateData { get; set; }

		public SDeviceMappinData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
