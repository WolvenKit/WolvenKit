import importlib.util
import unittest
from pathlib import Path

MODULE_PATH = Path(__file__).resolve().parents[1] / "compile_changelog.py"
spec = importlib.util.spec_from_file_location("compile_changelog", MODULE_PATH)
compile_changelog = importlib.util.module_from_spec(spec)
spec.loader.exec_module(compile_changelog)


class ChangelogRenderingTests(unittest.TestCase):
    def render(self, entry: dict) -> tuple[dict, str, str]:
        grouped = compile_changelog.group_changes([entry])
        return grouped, compile_changelog.build_markdown("1.0.0", grouped), compile_changelog.build_bbcode("1.0.0", grouped)

    def test_array_authors_and_pr_numbers(self) -> None:
        grouped, markdown, bbcode = self.render(
            {
                "type": "added",
                "packages": ["App"],
                "pr-number": [123, 456],
                "author": ["alice", "bob"],
                "description": "Combined change",
            }
        )

        item = grouped["App"]["added"][0]
        self.assertEqual(item["authors"], ["alice", "bob"])
        self.assertEqual(item["pr_numbers"], ["123", "456"])
        self.assertIn("* *Added*: Combined change by @alice, @bob", markdown)
        self.assertIn("[*] [i]Added[/i]: Combined change by @alice, @bob", bbcode)

    def test_single_author_and_pr_number(self) -> None:
        grouped, markdown, bbcode = self.render(
            {
                "type": "fixed",
                "packages": ["CLI"],
                "pr-number": 789,
                "author": "carol",
                "description": "Single contributor",
            }
        )

        item = grouped["CLI"]["fixed"][0]
        self.assertEqual(item["authors"], ["carol"])
        self.assertEqual(item["pr_numbers"], ["789"])
        self.assertIn("* *Fixed*: Single contributor by @carol", markdown)
        self.assertIn("[*] [i]Fixed[/i]: Single contributor by @carol", bbcode)

    def test_legacy_comma_separated_authors(self) -> None:
        _, markdown, bbcode = self.render(
            {
                "type": "changed",
                "packages": ["App"],
                "author": "dave, erin",
                "description": "Legacy attribution",
            }
        )

        self.assertIn("by @dave, @erin", markdown)
        self.assertIn("by @dave, @erin", bbcode)

    def test_missing_authors_are_not_attributed(self) -> None:
        _, markdown, bbcode = self.render(
            {"type": "added", "packages": ["App"], "description": "No author"}
        )

        self.assertIn("* *Added*: No author\n", markdown)
        self.assertIn("[*] [i]Added[/i]: No author\n", bbcode)


if __name__ == "__main__":
    unittest.main()
