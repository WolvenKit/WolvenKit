from argparse import ArgumentParser
from pathlib import Path
from typing import Any

import yaml


class ChangelogDumper(yaml.SafeDumper):
    pass


def represent_list(dumper: yaml.Dumper, data: list[Any]) -> yaml.SequenceNode:
    use_flow_style = all(isinstance(item, str) for item in data)
    return dumper.represent_sequence(
        "tag:yaml.org,2002:seq",
        data,
        flow_style=use_flow_style,
    )


ChangelogDumper.add_representer(list, represent_list)


def read_yaml_file(path: Path) -> dict[str, Any]:
    with path.open("r", encoding="utf-8") as file:
        data = yaml.safe_load(file)

    if data is None:
        return {}

    if not isinstance(data, dict):
        raise ValueError(f"Expected YAML object in {path}, got {type(data).__name__}")

    return data


def write_yaml_file(path: Path, data: dict[str, Any]) -> None:
    with path.open("w", encoding="utf-8") as file:
        yaml.dump(
            data,
            file,
            Dumper=ChangelogDumper,
            sort_keys=False,
            allow_unicode=True,
            default_flow_style=False,
        )


def normalize_changes(value: Any, source: Path) -> list[Any]:
    if value is None:
        return []

    if not isinstance(value, list):
        raise ValueError(f"Expected 'changes' to be a list in {source}")

    return value


def collect_unreleased_changes(unreleased_dir: Path) -> tuple[list[Any], list[Path]]:
    if not unreleased_dir.exists():
        return [], []

    if not unreleased_dir.is_dir():
        raise NotADirectoryError(f"{unreleased_dir} is not a directory")

    changes: list[Any] = []
    files_to_delete: list[Path] = []

    for path in sorted(unreleased_dir.iterdir()):
        if not path.is_file():
            continue

        if path.suffix.lower() not in {".yaml", ".yml"}:
            continue

        data = read_yaml_file(path)
        changes.extend(normalize_changes(data.get("changes"), path))
        files_to_delete.append(path)

    return changes, files_to_delete


def append_changes_to_unreleased_file(unreleased_file: Path, changes: list[Any]) -> None:
    if unreleased_file.exists():
        data = read_yaml_file(unreleased_file)
    else:
        data = {}

    existing_changes = normalize_changes(data.get("changes"), unreleased_file)
    existing_changes.extend(changes)

    data["changes"] = existing_changes
    write_yaml_file(unreleased_file, data)


def delete_files(paths: list[Path]) -> None:
    for path in paths:
        path.unlink()


def parse_args() -> tuple[Path, Path]:
    parser = ArgumentParser(
        description=(
            "Append changes from YAML files in an unreleased changelog directory "
            "to an unreleased changelog YAML file."
        )
    )
    parser.add_argument(
        "unreleased_dir",
        type=Path,
        help="Directory containing unreleased changelog YAML files.",
    )
    parser.add_argument(
        "unreleased_file",
        type=Path,
        help="YAML file whose 'changes' list should be appended to.",
    )

    args = parser.parse_args()
    return args.unreleased_dir, args.unreleased_file


def main() -> None:
    unreleased_dir, unreleased_file = parse_args()

    changes, files_to_delete = collect_unreleased_changes(unreleased_dir)

    if not changes:
        return

    append_changes_to_unreleased_file(unreleased_file, changes)
    delete_files(files_to_delete)


if __name__ == "__main__":
    main()
