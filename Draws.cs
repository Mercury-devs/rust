
        /// Отрисовывает визуальные линии,стреклу,сферу,текст или бокс по координатам

        public void Line(BasePlayer player, Vector3 from, Vector3 to, Color color, float duration) 
        {
            player.SendConsoleCommand("ddraw.line", duration, color, from, to);
        }

        public void Arrow(BasePlayer player, Vector3 from, Vector3 to, float headSize, Color color, float duration) 
        {
            player.SendConsoleCommand("ddraw.arrow", duration, color, from, to, headSize);
        }

        public void Sphere(BasePlayer player, Vector3 pos, float radius, Color color, float duration) 
        {
            player.SendConsoleCommand("ddraw.sphere", duration, color, pos, radius);
        }

        public void Text(BasePlayer player, Vector3 pos, string text, Color color, float duration) 
        {
            player.SendConsoleCommand("ddraw.text", duration, color, pos, text);
        }

        public void Box(BasePlayer player, Vector3 pos, float size, Color color, float duration) 
        {
            player.SendConsoleCommand("ddraw.box", duration, color, pos, size);
        }
