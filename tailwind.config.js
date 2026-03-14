/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./**/*.{razor,html,cshtml}",
    "./Components/**/*.{razor,html,cshtml}",
    "./Pages/**/*.{razor,html,cshtml}"
  ],
  theme: {
    extend: {
      fontFamily: {
        sans: ['ClashDisplay', 'sans-serif'],
        'clash': ['ClashDisplay', 'sans-serif'],
      },
    },
  },
  plugins: [],
}